using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core_MVC_pet_project.Data;
using Core_MVC_pet_project.Interfaces;
using Core_MVC_pet_project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Core_MVC_pet_project.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper,
            IHttpContextAccessor httpContextAccessor,
            UserManager<Employee> userManager,
            ILeaveAllocationRepository leaveAllocationRepository,
            AutoMapper.IConfigurationProvider configurationProvider) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.configurationProvider = configurationProvider;
        }

        public async Task CancelLeaveRequest(int leaveRequestId)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Cancelled = true;
            await UpdateAsync(leaveRequest);
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approvalstatus)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approvalstatus;

            if (approvalstatus)
            {
                var allocation = await leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                allocation.NumberOfDays -= daysRequested;

               await leaveAllocationRepository.UpdateAsync(allocation);
            }
            await UpdateAsync(leaveRequest);

        }

        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);

            var allocation = await leaveAllocationRepository.GetEmployeeAllocation(user.Id, model.LeaveTypeId);
            if (allocation == null)
            {
                return false;
            }
            int daysRequested = (int)(model.EndDate.Value - model.StartDate.Value).TotalDays;

            if (daysRequested > allocation.NumberOfDays)
            {
                return false;
            }

            var leaveRequest = mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);
            return true;
        }

        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList()
        {
            var leaveRequests = await context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };

            foreach (var leaveRequest in model.LeaveRequests)
            {
                leaveRequest.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }
            
            return model;
        }

        public async Task<List<LeaveRequestVM>> GetAllAsync(string employeeId)
        {
            return await context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId)
                .ProjectTo<LeaveRequestVM>(configurationProvider)
                .ToListAsync();
        }

        public async Task<LeaveRequestVM> GetLeaveRequestAsync(int? id)
        {
            var leaveRequest = await context.LeaveRequests.Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.Id == id);

            if (leaveRequest == null)
            {
                return null;
            }
            
            var model = mapper.Map<LeaveRequestVM>(leaveRequest);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));

            return model;
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeavesDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var allocations = (await leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
            var requests = await GetAllAsync(user.Id);
            

            var model = new EmployeeLeaveRequestViewVM(allocations, requests);

            return model;
        }
    }
    
}
