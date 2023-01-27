using Core_MVC_pet_project.Contracts;
using Core_MVC_pet_project.Data;

namespace Core_MVC_pet_project.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, Contracts.ILeaveTypeRepository
    {
        private readonly Data.ILeaveTypeRepository context;

        public LeaveTypeRepository(Data.ILeaveTypeRepository context) : base(context)
        {
            this.context = context;
        }    
    }
}
