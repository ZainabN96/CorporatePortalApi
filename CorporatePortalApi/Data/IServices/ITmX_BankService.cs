using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_BankService
    {
        Task<TmX_Bank> Get(int id);
        Task<IEnumerable<TmX_Bank>> GetAllBankAsync();
        TmX_Bank Add(TmX_Bank TmX_Bank);
        Task<bool> IsBankExist(string name);
        Task<bool> IsBankExistInUpdate(string name, int id);
    }
}
