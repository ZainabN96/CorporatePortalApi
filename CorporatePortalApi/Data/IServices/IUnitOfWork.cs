namespace CorporatePortalApi.Data.IServices
{
    public interface IUnitOfWork
    {
        IAspNetUserService AspNetUserService { get; }
        ITmX_CorporateService TmX_CorporateService { get; }
        Task<bool> SaveAsync();
    }
}
