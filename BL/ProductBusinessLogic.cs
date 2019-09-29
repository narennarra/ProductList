using DataAccessLayer;
using Model;
using System.Collections.Generic;

namespace BL
{
    public class ProductBusinessLogic : IProductBusinessLogic
    {
        private IProductDataAccess _ProductDataAccess;
        public ProductBusinessLogic(IProductDataAccess productDataAccess)
        {
            _ProductDataAccess = productDataAccess;

        }
        public Product GetProductById(int productId)
        {
            return _ProductDataAccess.GetProductById(productId);
            
        }

        public List<Product> GetProducts()
        {
            return _ProductDataAccess.GetAllProducts();
        }
    }
}
