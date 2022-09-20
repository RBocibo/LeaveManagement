using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
