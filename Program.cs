using System;
namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayiyi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 1)
            {
                sayi*=2;
            }
            else
            {
                sayi /= 2;
            }
            Console.WriteLine(sayi);
        }
    }
}
