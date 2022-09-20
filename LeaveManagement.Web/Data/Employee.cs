using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string TaxId { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
