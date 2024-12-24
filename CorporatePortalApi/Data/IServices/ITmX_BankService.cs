using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_BankService
    {
        Task<TmX_Bank> Get(int id);
        TmX_Bank Add(TmX_Bank TmX_Bank);
        Task<TmX_Bank> GetWithBankName(string bname);
        Task<IEnumerable<TmX_Bank>> GetTmX_BankAsync();
        Task<bool> IsTmX_BankExist(string bankName);
        Task<bool> IsTmX_BankExistInUpdate(string bankName, int id);

	}
}
