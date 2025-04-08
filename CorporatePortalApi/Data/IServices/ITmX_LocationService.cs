using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_LocationService
    {
        Task<TmX_Location> Get(int id);
        Task<IEnumerable<TmX_Location>> GetAll();
        TmX_Location Add(TmX_Location TmX_Location);
    }
}
