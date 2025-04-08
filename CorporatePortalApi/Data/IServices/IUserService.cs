using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IUserService
    {
        TmX_User Add(TmX_User user);
        Task<TmX_User> Get(Guid id);
        Task<TmX_User?> GetByParentId(Guid id);
		Task<TmX_User> GetWithName(string firstname, string lastname);
        Task<TmX_User> GetWithServer_User_ID(string serverUId);
        Task<IEnumerable<TmX_User>> GetAllUsersAsync();
        Task<bool> IsUserExist(string firstname, string lastname);
        Task<bool> IsUserExistInUpdate(string firstname, string lastname, Guid id);
    }
}
