//i sayaç anlamına gelir, ; sonrası ise şarttır.
//++ bir bir arttır demek
// i ye bir değerini veriyoruz i=1 de
//i 1 e şit olduğunda tekrar başa döner ve i =2 olur sonra tekrar başa döner ve i=3 olur ++ dan kaynaklı olarak
//en sonunda i=10 olduğunda } dan itibaret okumaya devam eder.



string kurs1 = "Yazılım Gelistirici Yetistirme Kampı";
string kurs2 = "Programlamaya Baslama icin temel kurs";
string kurs3 = "Java";

//array - dizi  

string[] kurslar = new string[] { "Yazılım Gelistirici Yetistirme Kampı", "Programlamaya Baslama icin temel kurs", "Java","Develer", "C#" };



//programlama dilleri 0 dan saymaya başlar,O Yazılm Gelistirici Yetistirme Kampı 1 Programlamaya Baslama icin temel kurs
//i<3 elimizde 3 tane veri olduğu için 3 tür.0 dan başlama sebebi 0 1 2 bak 3 adet veri.
//.Lenght dizinin uzunluğunu kasteder.  


for (int i = 0; i<kurslar.Length; i++)
{
	Console.WriteLine(kurslar[i]);
        
}
Console.WriteLine("For bitti");


//foreach dizi temelli yapıları tek tek dönmeye yarıyor.
// in kurslar kursları tek tek dolaş
//foreach dizilere uygulanır
//kurs takma isimdir oraya istediğini yazabilirsin.
//for dizi kullanımı genel amaçta kullanılır foreach da kullanılabilir ancak foreach daha kolaydır.

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}




Console.WriteLine("Sayfa sonu - footer");