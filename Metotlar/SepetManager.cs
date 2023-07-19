using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
	class SepetManager
	{
		//naming convention - ekle değil Ekle olarak ilk harf büyük yazılır.
		// eğer normal bir () var ise metot/fonksiyon var demektir.
		// python daki def fonksiyonu ile aynı göre void den sonraki komuta emir verildiğinde
		   //indentation içerisindeki komut çağrılır girer.
		   //parametre Urun urun
		   // void Ekle(Urun urun) bu kısma imza denir.
		   //"..... : " + urun.Adi (+) burada iki string i yan yana yazmaya yarıyor 
		
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urun.Adi);

		}
		//Diyelim ki bir başka parametre eklemek istedik eğer burada int StokAdedi eklersek
		//diğer sayfalarde teker teker veri eklemek gerekicek ancak 
		//Urun class ında özelliği eklediğimizde public void int StokAdedi dersek
		//encapsulation yaparak hiçbir sayfada değişiklik yapma gereği olmadan kolaylıkla
		//tüm sayfalara veri gelir.
		public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
		{
			Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
		}
	}

}
