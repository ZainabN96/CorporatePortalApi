using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_ProductService
    {
        TmX_Product Add(TmX_Product product);
        Task<TmX_Product> Get(int id);
        Task<TmX_Product> GetWithProductName(string pname);
        Task<TmX_Product> GetWithCompanyName(string cname);
        Task<IEnumerable<TmX_Product>> GetTmX_ProductAsync();
        Task<bool> IsTmX_ProductExist(string pName);
        Task<bool> IsTmX_ProductExistInUpdate(string pname, int id);
    }
}
