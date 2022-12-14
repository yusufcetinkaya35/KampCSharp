using Oop2;

//Musteri musteri1 = new Musteri();
//musteri1.Adi = "Nadir";
//musteri1.Soyadi = "Arslan";
//musteri1.Id = 1;
//musteri1.TcNo = "12345678901";
//musteri1.MusteriNo = "12345";

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Nadir";
musteri1.Soyadi = "Er";
musteri1.TcNo = "12345678901";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "123456789";

//Musteri hem GercekMusteri hem TuzelMusteri ref. tutabiliyor.
Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
