using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_Time_ZoneService
    {
        Task<TmX_Time_Zone> Get(int id);
        Task<TmX_Time_Zone> GetWithName(string name);
        Task<IEnumerable<TmX_Time_Zone>> GetTmX_Time_ZoneAsync();
        TmX_Time_Zone Add(TmX_Time_Zone TmX_Corporate);
        Task<bool> IsTmX_Time_ZoneExist(string name);
        Task<bool> IsTmX_Time_ZoneExistInUpdate(string name, int id);
    }
}
