using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    class Product
    {
        decimal _unitPrice;
        public  int Id { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice
        {
            get { return _unitPrice + _unitPrice * 18 / 100;  }
            set { _unitPrice = value; }
        }

        public decimal UnitInStock;
    }
}
