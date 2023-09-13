using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
	class Musteri //buradaki base sınıfımız referans tutucudur GercekMusteri ve TuzelMusterilerin referanslarını alabilmeyi sağlar.
	{
		public int Id { get; set; }
		public string MusteriNo { get; set; }


		//eğer bir nesnede bir değeri kullanmak zorunda gibi görünmüyosan o alanda hata vardır soyutlama hatası vardır
	}
}
