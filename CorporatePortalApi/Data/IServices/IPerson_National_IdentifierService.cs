﻿using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.IServices
{
    public interface IPerson_National_IdentifierService
    {
        Task<TmX_Person_National_Identifier> Get(int id);
        Task<IEnumerable<TmX_Person_National_Identifier>> GetAllPersonNationalIdentifierAsync();
        TmX_Person_National_Identifier Add(TmX_Person_National_Identifier TmX_PersonNI);
        Task<bool> IsNationalIdentifierExist(int personId);
        Task<bool> IsNationalIdentifierExistInUpdate(int personId, int id);
    }
}
