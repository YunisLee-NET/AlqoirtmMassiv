using System;
using System.Linq;

namespace AlqoritmDersler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int uzunluq = 0;
            int a;
            string enuzunmetn = " ";
            string[] massiv = new string[3];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = Console.ReadLine();
                a = massiv[i].Length;     
                Console.WriteLine("Herf sayi: " + a);
                
            }
            for(int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i].Length > uzunluq)
                {
                    uzunluq = massiv[i].Length;
                    enuzunmetn = massiv[i];
                    Console.WriteLine("En cox herf olan: " + uzunluq + " / " + enuzunmetn);
                }

            }
            Console.ReadLine();
        }
    }
}
