using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core_MVC_pet_project.Data
{
    public class ILeaveTypeRepository : IdentityDbContext<Employee>
    {
        public ILeaveTypeRepository(DbContextOptions<ILeaveTypeRepository> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}