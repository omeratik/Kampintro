using System;

namespace DegerVeReferansTipler
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int sayi1 = 10;
			int sayi2 = 30;
			sayi1 = sayi2;
			sayi2 = 65;
			//sayi1 kaçtır
			//sayi1 normalde değer olarak 10 biz sayi1 = sayi2 diyerek sayi1'in değerini
			//yok sayarak artık sayi2 nin değerini alıyoruz sayi2=30 du. Artık sayi1 değeri 30
			//olmuş oluyor. Sonrasında da sayi2' ye ise 65 değerini veriyoruz.
			
			
			int[] sayilar1 = new int[] { 10, 20, 30 };
			int[] sayilar2 = new int[] { 100, 200, 300 };
			sayilar1 = sayilar2;
			sayilar2[0] = 999;
			//sayilar1[0] kaçtır ?

		}
	}

}

//int,decimal,float,double,bool = sayısal görünümde olanlar *değer tip* dir.
//array,class,interface= *referans tip* dir.

//   stack          heap
   //sayilar1    
   //sayilar2