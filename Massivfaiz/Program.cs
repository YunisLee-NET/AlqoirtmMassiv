using System;

namespace Massivfaiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] faizmassiv = new int[5];
            Console.WriteLine("Ededleri daxil edin: ");
            for (int i = 0; i < faizmassiv.Length; i++)
            {
                faizmassiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ");
            Console.WriteLine("Cavablar:");
            for (int i = 0; i < faizmassiv.Length; i++)
            {
                Console.WriteLine(faizmassiv[i] * 1.1);
            }
        }
    }
}
