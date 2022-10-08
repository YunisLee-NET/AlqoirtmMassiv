using System;

namespace MassivCemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] massiv = new int[4];
            Console.WriteLine("Ededleri daxil edin: ");
            for(int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
            }
            int cavab = 0;
            for(int i = 0; i < massiv.Length; i++)
            {
                cavab = cavab + massiv[i];
            }
            Console.WriteLine("Cavab: " + cavab);
        }
    }
}
