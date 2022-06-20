using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models.Dtos
{
    public class EmployeeListDto
    {
        public string Id { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; } = string.Empty;
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty ;
        [Display(Name = "Date Joined")]
        public string DateJoined { get; set; } = string.Empty;
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;
    }
}
