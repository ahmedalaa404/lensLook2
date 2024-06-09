using lensLook.Dal;
using lensLook.Dal.Context;
using lensLook.Dal.models;

namespace lensLook.Bll
{
    public class ProductRepo : IProductRepo
    {
        private readonly LensLookDbContext _context;

        public ProductRepo(LensLookDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
