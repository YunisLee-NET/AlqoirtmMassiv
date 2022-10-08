using System;

namespace MassivMuqayise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] massiv = new int[2];
            Console.WriteLine("Ededleri daxil edin:");
            for (int i=0; i < massiv.Length; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
            }
            if ((massiv[0] == 15 || massiv[1] == 15) || (massiv[0] == 20 || massiv[1] == 20))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
