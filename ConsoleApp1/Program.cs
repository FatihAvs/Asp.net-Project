using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc;
            try
            {
                Console.WriteLine("1. sayıyı giriniz");
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz");
                sayi2 = int.Parse(Console.ReadLine());
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Bölüm Sonucu {0}", sonuc);  
            }
            catch (DivideByZeroException ) 
            {
                Console.WriteLine("Sıfıra bölemezsiniz");
            }
           
        }
    }

}
