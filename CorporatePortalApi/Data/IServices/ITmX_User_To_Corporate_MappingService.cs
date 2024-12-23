using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_User_To_Corporate_MappingService
    {
        TmX_User_To_Corporate_Mapping Add(TmX_User_To_Corporate_Mapping userCorporate);
        Task<TmX_User_To_Corporate_Mapping> Get(int id);
        Task<TmX_User_To_Corporate_Mapping> GetWithUser_Id(string userId);
        Task<TmX_User_To_Corporate_Mapping> GetWithCorporate_Id(int corporateid);
        Task<IEnumerable<TmX_User_To_Corporate_Mapping>> GetTmX_User_To_Corporate_MappingAsync();
        Task<bool> IsTmX_User_To_Corporate_MappingExist(int userMappingId, string userId, int corporateId);
        Task<bool> IsTmX_User_To_Corporate_MappingExistInUpdate(int userMappingId, string userId, int corporateId);

    }
}
