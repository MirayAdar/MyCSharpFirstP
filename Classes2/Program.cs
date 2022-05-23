using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products() { UnitPrice = 200, UnitsInStock = 8 }; // bu şekilde de aşağıdaki şekilde de instance'a değer verilebilir
            product1.ProductName = "Box";

            ProductService productService = new ProductService();
            productService.AddProduct(product1);

            int sonuc = productService.AddParams(new int[] { 2, 3, 4, 5, 6 });

        }
    }
}
