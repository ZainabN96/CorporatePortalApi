using CorporatePortalApi.Data.IServices;
using CorporatePortalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporatePortalApi.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext dc;

        public ProductService(ApplicationDbContext dc)
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
                                       .Include(x => x.Currency)       
                                       .Include(x => x.Bank)
                                       .Include(x => x.Tenant)
                                       .FirstOrDefaultAsync();
        }       
        public async Task<TmX_Product> GetWithCompanyName(string cname)
        {
            return await dc.TmX_Product.Where(x => x.Company_Name == cname)
				                       .Include(x => x.Currency)
									   .Include(x => x.Bank)
									   .Include(x => x.Tenant)
									   .FirstOrDefaultAsync();
        }
        
        public async Task<IEnumerable<TmX_Product>> GetProductAsync()
        {
            return await dc.TmX_Product.Where(x => x.Active_Flag == true)
                                       .OrderBy(x => x.Product_Name)
									   .Include(x => x.Currency)
									   .Include(x => x.Bank)
									   .Include(x => x.Tenant)
									   .ToListAsync();
        }

        public async Task<bool> IsProductExist(string pName)
        {
            return await dc.TmX_Product.AnyAsync(x => x.Product_Name == pName);
        }

        public async Task<bool> IsProductExistInUpdate(string pname, int id)
        {
            return await dc.TmX_Product.AnyAsync(x => x.Product_Name == pname && x.Product_ID != id);
        }
    }
}
