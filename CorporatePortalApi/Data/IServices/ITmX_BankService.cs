using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_BankService
    {
        Task<TmX_Bank> Get(int id);
        TmX_Bank Add(TmX_Bank TmX_Bank);
    }
}
