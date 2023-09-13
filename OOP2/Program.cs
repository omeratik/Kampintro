namespace OOP2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GercekMusteri musteri1= new GercekMusteri();
			musteri1.Id= 1;
			musteri1.MusteriNo = "12345";
			musteri1.Adi = "Ömer";
			musteri1.Soyadi = "Atik";
			musteri1.TcNo = "1234567890";

			//Kodlama.io
			TuzelMusteri musteri2 = new TuzelMusteri();
			musteri2.Id = 2;
			musteri2.MusteriNo = "54321";
			musteri2.SirketAdi = "Kodlama.io";
			musteri2.VergiNo = "1234567890";

			//Gerçek(Coorporate) Müsteri - Tüzel(Indivual) Müsteri birbirinin yerine asla kullanılamaz.
			//SOLID (L)

			Musteri musteri3 = new GercekMusteri(); //Burada referans  alabilmesini sağlıyoruz.
			Musteri musteri4 = new TuzelMusteri();

			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Ekle(musteri1);
			musteriManager.Ekle(musteri2);
			musteriManager.Ekle(musteri3);




		}
	}
}