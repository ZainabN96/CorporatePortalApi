﻿using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_CorporateService: ITmX_CorporateService
    {
        private readonly ApplicationDbContext dc;

        public TmX_CorporateService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Corporate Add(TmX_Corporate TmX_Corporate)
        {

            dc.TmX_Corporate.Add(TmX_Corporate);

            return TmX_Corporate;
        }

        public async Task<TmX_Corporate> Get(int id)
        {
            return await dc.TmX_Corporate.FindAsync(id);
        }

        public async Task<TmX_Corporate> GetWithName(string name)
        {
            return await dc.TmX_Corporate.Where(x => x.Corporate_Name == name)
                                       .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TmX_Corporate>> GetTmX_CorporateAsync()
        {
            return await dc.TmX_Corporate.Where(x => x.Active_Flag == true )
                                       .OrderBy(x => x.Corporate_Name)
                                       .ToListAsync();
        }

        public async Task<bool> IsTmX_CorporateExist(string name)
        {
            return await dc.TmX_Corporate.AnyAsync(x => x.Corporate_Name == name);
        }

        public async Task<bool> IsTmX_CorporateExistInUpdate(string name, int id)
        {
            return await dc.TmX_Corporate.AnyAsync(x => x.Corporate_Name == name && x.Corporate_Id != id);
        }


    }
}