O references
static void Main(string[] args)
{
    //out parametreler
    string sayi = "999";
    bool sonuc = int.TryParse(sayi, out int outSayi);
    if (sonuc)
    {
        Console.WriteLine("Başarili!");
        Console.WriteLine(outSayi);
    }
    else
    {
        Console.WriteLine("Başarisiz!");
    }

    Metotlar instance = new Metotlar();
    instance.Topla(4, 5, out int toplamSonucu);
    Console.WriteLine(toplamSonucu);

    //Metot Aşiri Yükleme Overloading
    int ifade = 999;
    instance.EkranaYazdir(ifade);
    instance.EkranaYazdir("Fatma BULUT");
}

2 references

class Metotlar
{
    1 reference
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2 )
    {
        Console.WriteLine(veri1 + veri2 );
    }

}

