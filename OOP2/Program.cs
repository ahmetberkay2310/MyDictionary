using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1111111";
            musteri1.Ad = "Berkay";
            musteri1.Soyad = "karabulut";
            musteri1.TcNo = "2222222222222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "22222222";
            musteri2.SirketAd = "Zpashazade";
            musteri2.VergiNo = "12345";

            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(musteri1);
            musterimanager.Add(musteri2);



        }
    }
}
