using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_LocationService
    {
        Task<TmX_Location> Get(int id);
        TmX_Location Add(TmX_Location TmX_Location);
    }
}
