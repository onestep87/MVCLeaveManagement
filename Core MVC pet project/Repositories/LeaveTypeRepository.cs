using Core_MVC_pet_project.Contracts;
using Core_MVC_pet_project.Data;

namespace Core_MVC_pet_project.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, Contracts.ILeaveTypeRepository
    {
        private readonly ApplicationDbContext context;

        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }    
    }
}
