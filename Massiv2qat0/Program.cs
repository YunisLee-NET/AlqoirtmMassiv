using System;

namespace Massiv2qat0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] a = new int[5];
            for(int i=0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------------");
            int[] b = new int[a.Length * 2];
            b[0] = a[0];
            Console.WriteLine(b[0]);
            for (int i=1;i<b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
