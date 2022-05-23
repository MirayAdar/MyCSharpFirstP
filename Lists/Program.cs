using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "İstanbul", "Ankara", "İzmir" };

            cities.Add("Bursa");
            int[] sayi = new int[]{ 0, 1, 2, 3};
            int[] sayi1 = new int[] { 4, 5, 6 };

            sayi = sayi1;

            //Console.WriteLine(sayi[3]);

        }
    }
}
