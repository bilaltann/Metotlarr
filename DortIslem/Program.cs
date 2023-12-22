namespace DortIslem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Hesapla hesapla = new Hesapla(); // olusturduğumuz Hesapla classını burda örnekleyerek istedigimiz islemleri yapiyoruz.
            hesapla.Topla(34, 13);
            hesapla.Topla(88, 55);
        }
    }
}
