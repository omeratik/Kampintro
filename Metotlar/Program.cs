using System;
using System.Data.Common;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			string urunAdi = "Elma;";
			double fiyati = 15;
			string aciklama = "Amasya Elması";

			string[] meyveler = new string[] { };

			//
			
			Urun urun1 = new Urun();
			urun1.Adi = "Elma";
			urun1.Fiyatı = 15;
			urun1.Aciklama = "Amasya Elması";

			Urun urun2 = new Urun();
			urun2.Adi = "Karpuz";
			urun2.Fiyatı = 80;
			urun2.Aciklama = "Diyarbakır karpuzu";

			Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe -- tip güvenli
			foreach (var urun in urunler)
            {		    
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyatı);
				Console.WriteLine(urun.Aciklama);
				Console.WriteLine("-----------------------");


            }

			Console.WriteLine("-----------------Metodlar------------------");

			//class çağırma örneği, instance - örnek
			SepetManager sepetManager = new SepetManager();
			
			//sepetManager.Ekle() metodu çağırma .Ekle();
			//encapsulation kapsülleme
			
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);

			sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
			sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
			sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
		}
	}
}


//Metodlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
//Don't repeat yourself - DRY Clean Code - Best Practice 
