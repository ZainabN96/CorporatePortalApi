using CorporatePortalApi.Models;

namespace CorporatePortalApi.Data.Services
{
    public class TmX_ProductService : ITmX_ProductService
    {
        private readonly ApplicationDbContext dc;

        public TmX_ProductService(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public TmX_Product Add(TmX_Product product)
        {
            product.Last_Updated_Date = DateTime.Now;
            dc.TmX_Product.Add(product);

            return product;
        }

        public async Task<TmX_Product> Get(int id)
        {
            return await dc.TmX_Product.FindAsync(id);
        }

        public async Task<TmX_Product> GetWithProductName(string pname)
        {
            return await dc.TmX_Product.Where(x => x.Product_Name == pname)
                                       .FirstOrDefaultAsync();
        } 
        public async Task<TmX_Product> GetWithCompanyName(string cname)
        {
            return await dc.TmX_Product.Where(x => x.Company_Name == cname)
                                       .FirstOrDefaultAsync();
        }
        
        public async Task<IEnumerable<TmX_Product>> GetTmX_ProductAsync()
        {
            return await dc.TmX_Product.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.Product_Name)
                                       .ToListAsync();
        }

        public async Task<bool> IsTmX_ProductExist(string pName)
        {
            return await dc.TmX_Product.AnyAsync(x => x.Product_Name == pName);
        }

        public async Task<bool> IsTmX_ProductExistInUpdate(string pname, int id)
        {
            return await dc.TmX_Product.AnyAsync(x => x.Product_Name == pname && x.Product_ID != id);
        }
    }
}
