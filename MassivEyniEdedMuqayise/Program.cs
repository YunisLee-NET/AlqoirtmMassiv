using System;

namespace MassivEyniEdedMuqayise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[2];
            Console.WriteLine("Ededleri daxil edin:");
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
            }
            if ((massiv[0] == 10 && massiv[1] == 10) || (massiv[0] == 20 && massiv[1] == 20))
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
