namespace CorporatePortalApi.Data.IServices
{
    public interface IUnitOfWork
    {
       // IAspNetUserService AspNetUserService { get; }
        Task<bool> SaveAsync();
    }
}
