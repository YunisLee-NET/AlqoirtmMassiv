using System;
using System.Linq;

namespace MassivTers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] massiv = new int[4];
            Console.WriteLine("Ededleri daxil edin:");
            for(int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            Console.WriteLine("Max ededin massivi");
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine(massiv.Max());
            }

            Console.WriteLine(" ");
            Console.WriteLine("Ters massiv");
            for(int i = massiv.Length - 1; i >= 0; i--)
            {                
                Console.WriteLine(massiv[i]);
            }
            Console.ReadLine();
        }
    }
}
