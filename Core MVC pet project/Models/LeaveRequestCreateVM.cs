using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Core_MVC_pet_project.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        public SelectList? LeaveTypes { get; set; }
        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //if (StartDate > EndDate)
            //{
            //    yield return new ValidationResult("The start date must be before end date", new[] { nameof(StartDate), nameof(EndDate) });
            //}
            
            if (RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comment is too long", new[] { nameof(RequestComments) });
            }
        }
    }
}
