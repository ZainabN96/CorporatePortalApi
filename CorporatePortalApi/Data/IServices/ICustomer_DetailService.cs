using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ICustomer_DetailService
    {
        Task<TmX_Customer_Detail> Get(int id);
        Task<IEnumerable<TmX_Customer_Detail>> GetAllCustomerDetailAsync();
        TmX_Customer_Detail Add(TmX_Customer_Detail TmX_Customer_Detail);
        Task<bool> IsCustomerDetailExist(string taxNo);
        Task<bool> IsCustomerDetailExistInUpdate(string taxNo , int id);


    }
}
