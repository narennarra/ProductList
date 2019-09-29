using Model;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class ProductDataAccess : IProductDataAccess
    {
        private List<Product> _products;

        public ProductDataAccess()
        {
            if (_products == null)
            {
                Initialiseproducts();
            }
        }

        private void Initialiseproducts()
        {
            AddProduct("Cheese ", 27.5m, 50, "https://www.sals.co.nz/wp-content/uploads/MenuCheese.jpg");
            AddProduct("Pepperoni", 33.5m, 48, "https://www.sals.co.nz/wp-content/uploads/MenuPepperoni-1.jpg");
            AddProduct("Meatball", 34.5m, 30, "https://www.sals.co.nz/wp-content/uploads/MenuMeatball.jpg");
            AddProduct("Sausage", 34.5m, 28, "https://www.sals.co.nz/wp-content/uploads/MenuSausage.jpg");
            AddProduct("Veggie", 33.5m, 20, "https://www.sals.co.nz/wp-content/uploads/MenuVeggie.jpg");

        }

            private void AddProduct(string name, decimal price, int stock, string image)
            {
            if (_products == null)
                _products = new List<Product>();
                _products.Add(
                    new Product
                    {
                        ProductId= _products.Count+1,
                        Name=name,
                        Price=price,
                        Stock=stock,
                        Image=image 
                    });
            }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
