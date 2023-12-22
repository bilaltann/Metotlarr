namespace Metotlarr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 14;
            urun1.Aciklama = "alanya elmasi";

            Product urun2= new Product();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 45;
            urun2.Aciklama = "diyarbakir karpuzu";

            Product[] products = new Product[] { urun1, urun2 };
            
            // type-safe --tip güvenli
            foreach (Product product in products) 
            {
                Console.WriteLine(product.Adi+"------"+product.Fiyati);
            
            }
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
            Console.WriteLine("Hello, World!");
        }
    }
}
