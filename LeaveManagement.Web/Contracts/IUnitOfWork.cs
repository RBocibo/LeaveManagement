namespace LeaveManagement.Web.Contracts
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
