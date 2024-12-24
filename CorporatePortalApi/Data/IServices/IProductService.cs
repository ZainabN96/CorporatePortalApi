using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IProductService
    {
        TmX_Product Add(TmX_Product product);
        Task<TmX_Product> Get(int id);
        Task<TmX_Product> GetWithProductName(string pname);
        Task<TmX_Product> GetWithCompanyName(string cname);
        Task<IEnumerable<TmX_Product>> GetProductAsync();
        Task<bool> IsProductExist(string pName);
        Task<bool> IsProductExistInUpdate(string pname, int id);
    }
}
