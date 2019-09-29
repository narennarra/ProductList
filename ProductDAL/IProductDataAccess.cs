using Model;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IProductDataAccess
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
    }
}
