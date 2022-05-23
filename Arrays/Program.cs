using System;

namespace Arrays
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

            Console.WriteLine(krediler);

            int[] numbers = new int[3];
            numbers[0] = 4;
            numbers[1] = 6;
            numbers[2] = 5;

            Console.WriteLine(numbers);
        }
    }
}
