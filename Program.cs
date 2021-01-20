using System;

namespace Firstdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80 ;
            urun2.Aciklama = "Dİyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");


            }

            Console.WriteLine("----------------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            

            Console.WriteLine("Hello World!");
        }
    }
}
