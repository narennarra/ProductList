using Model;
using System.Collections.Generic;

namespace BL
{
    public interface IProductBusinessLogic
    {
        List<Product> GetProducts();

        Product GetProductById(int productId);
    }
}
