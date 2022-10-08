using System;

namespace UzunluqMisal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int sayac = 0;
            string metin = "www.yazilimkodlama.com";
            string aranan = "ahmet";
            int metinuzunluk = metin.Length;
            int arananuzunluk = aranan.Length;

            for (int i = 0; i <= (metinuzunluk - arananuzunluk); i++)
            {
                if (metin.Substring(i, arananuzunluk) == aranan)
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
            Console.ReadKey();
        }
    }
}
