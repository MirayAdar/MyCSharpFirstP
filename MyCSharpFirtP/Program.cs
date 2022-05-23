using System;

namespace MyCSharpFirtP
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3000;
            int num2 = 4000;
            string sonuc;
            sonuc = num1 >= num2 ? "Sayı1 sayı2 den büyük" : "Sayı2 sayı1den büyük";
            Console.WriteLine(sonuc);
        }
    }
}
