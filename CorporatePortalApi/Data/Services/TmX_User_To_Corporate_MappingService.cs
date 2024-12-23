using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_User_To_Corporate_MappingService: ITmX_User_To_Corporate_MappingService
    {
        private readonly ApplicationDbContext dc;

        public TmX_User_To_Corporate_MappingService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_User_To_Corporate_Mapping Add(TmX_User_To_Corporate_Mapping userCorporate)
        {
            userCorporate.Last_Updated_Date = DateTime.Now;
            dc.TmX_User_To_Corporate_Mapping.Add(userCorporate);

            return userCorporate;
        }

        public async Task<TmX_User_To_Corporate_Mapping> Get(int id)
        {
            return await dc.TmX_User_To_Corporate_Mapping.FindAsync(id);
        }

        public async Task<TmX_User_To_Corporate_Mapping> GetWithUser_Id(string userId)
        {
            return await dc.TmX_User_To_Corporate_Mapping.Where(x => x.User_Id == userId)
                                       .FirstOrDefaultAsync();
        }
        public async Task<TmX_User_To_Corporate_Mapping> GetWithCorporate_Id(int corporateid)
        {
            return await dc.TmX_User_To_Corporate_Mapping.Where(x => x.Corporate_Id == corporateid)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TmX_User_To_Corporate_Mapping>> GetTmX_User_To_Corporate_MappingAsync()
        {
            return await dc.TmX_User_To_Corporate_Mapping.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.User_To_Corporate_Mapping_Id)
                                       .ToListAsync();
        }

        public async Task<bool> IsTmX_User_To_Corporate_MappingExist(int userMappingId, string userId, int corporateId)
        {
            return await dc.TmX_User_To_Corporate_Mapping.AnyAsync(x => x.User_To_Corporate_Mapping_Id == userMappingId && x.User_Id== userId && x.Corporate_Id== corporateId);
        }

        public async Task<bool> IsTmX_User_To_Corporate_MappingExistInUpdate(int userMappingId, string userId, int corporateId)
        {
            return await dc.TmX_User_To_Corporate_Mapping.AnyAsync(x => x.User_Id == userId && x.Corporate_Id == corporateId && x.User_To_Corporate_Mapping_Id != userMappingId);
        }
    }
}
