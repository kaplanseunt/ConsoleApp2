using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Aciklama = "Amasya elma";
            urun1.Adi = "elma";
            urun1.Fiyati = 4;

            Urun urun2 = new Urun();
            urun2.Aciklama = "Samsun Şeftalisi";
            urun2.Adi = "Şeftali";
            urun2.Fiyati = 12;

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }
            Console.WriteLine(" ");
            Console.WriteLine("----------Metotlar-----------");
            Console.WriteLine(" ");
            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
             


        }
    }
}
