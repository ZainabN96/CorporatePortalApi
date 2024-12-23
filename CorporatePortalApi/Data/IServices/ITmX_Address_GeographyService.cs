using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface ITmX_Address_GeographyService
    {

        Task<TmX_Address_Geography> Get(int id);
        TmX_Address_Geography Add(TmX_Address_Geography TmX_Address_Geography);
    }
}
