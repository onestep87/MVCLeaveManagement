using Core_MVC_pet_project.Contracts;
using Core_MVC_pet_project.Data;
using Core_MVC_pet_project.Models;

namespace Core_MVC_pet_project.Interfaces
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeavesDetails();
        Task<LeaveRequestVM> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequestVM>> GetAllAsync(string employeeId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task ChangeApprovalStatus(int leaveRequestId, bool approvalstatus);
        Task CancelLeaveRequest(int leaveRequestId);
    }
}
