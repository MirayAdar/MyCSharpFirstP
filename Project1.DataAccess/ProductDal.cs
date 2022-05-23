using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataAccess
{
    public class ProductDal
    {
        List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product> {
                new Product { ProductId = 1, ProductName = "Samsung Tv", QuantityPerUnit = "8 gb ram", UnitPrice = 1000, UnitsInStock = 8 },
                new Product { ProductId = 2, ProductName = "Vestel Tv", QuantityPerUnit = "8 gb ram", UnitPrice = 1000, UnitsInStock = 8 },
                new Product { ProductId = 3, ProductName = "Panasonic Tv", QuantityPerUnit = "8 gb ram", UnitPrice = 1000, UnitsInStock = 8 }
            };
        }
        public List<Product> GetAll()
        {

        }
    }
}
