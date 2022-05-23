using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] krediler = new string[7];
            krediler[0] = "Hızlı Kredi";
            krediler[1] = "Kredi2";
            krediler[2] = "Kredi 3";
            krediler[3] = "Kredi4";
            krediler[4] = "Kredi5";
            krediler[5] = "Kredi6";
            krediler[6] = "Kredi7";

            for (int i = 0;  i<7;  i++ ) {
                Console.WriteLine(krediler[i]);
            }

            foreach ( var kredi in krediler)
            {
                Console.WriteLine(kredi);
            }

            int sayi1 = 220;
            int sayi2 = 284;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i<sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }
            for (int i = 1; i < sayi2; i++)
            {
                if (sayi2 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            if (sum1 == sayi2 && sum2 == sayi1)
            {
                Console.WriteLine("Theese are Amicable Numbers.");
            }
            else
            {
                Console.WriteLine("Theese are not Amicable Numbers.");
            }
       
        }
    }
}
