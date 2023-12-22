using System.Net.Http.Headers;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int decimal float, double ,bool --> değer tip.
            //array class interface --> referans tip
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1'e sayi2 değerini atadi
            sayi2 = 65;
            //sayi1 ?? 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //referans numaralari eşitlendi.
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999

            Console.ReadLine();

        }
    }
}
