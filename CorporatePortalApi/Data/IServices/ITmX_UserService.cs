using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_UserService
    {
        TmX_User Add(TmX_User user);
        Task<TmX_User> Get(string id);
        Task<TmX_User> GetWithName(string firstname, string lastname);
        Task<TmX_User> GetWithServer_User_ID(string serverUId);
        Task<IEnumerable<TmX_User>> GetTmX_UserAsync();
        Task<bool> IsTmX_UserExist(string firstname, string lastname);
        Task<bool> IsTmX_UserExistInUpdate(string firstname, string lastname, string id);
    }
}
