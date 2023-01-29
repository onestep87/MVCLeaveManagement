namespace Core_MVC_pet_project.Models
{
    public class LeaveAllocationEditVM : LeaveAllocationVM
    {
        public int LeaveTypeId { get; set; }
        public string? EmployeeId { get; set; }
        public EmployeeListVM? Employee { get; set; }
    }
}
