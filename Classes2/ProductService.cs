using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class ProductService
    {
        public void AddProduct(Products product)
        {
            Console.WriteLine("Ürün eklendi" +product.ProductName);
        }
        public int AddParams(params int[] numbers)
        {
            int result = 0;
            foreach (var num in numbers)
            {
                result +=num;
            }
            return result;
            {

            }
        }
    }
}
