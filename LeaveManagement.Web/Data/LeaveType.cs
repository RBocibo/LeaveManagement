namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int DefaultDays { get; set; }
    }
}
