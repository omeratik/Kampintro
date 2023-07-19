string[] Ürünler = new string[] { "Bebek bezi", "Un", "Eldiven", "Matkap" };

foreach (string ürün in Ürünler)
{
    Console.WriteLine(ürün);
}

Console.WriteLine("BİRİNCİ DONGU BİTTİ");

for (int i = 0; i <Ürünler.Length; i++)
{
    Console.WriteLine(Ürünler[i]);
}