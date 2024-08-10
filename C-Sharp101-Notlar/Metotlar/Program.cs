class Program
{
    static void Main(string[] args)
    {
        // İki tam sayı değişkeni tanımlama
        int a = 2;
        int b = 3;

        // Toplama işlemi ve sonucun ekrana yazdırılması
        Console.WriteLine(a + b);

        // Topla isimli bir metot tanımlama ve çağırma
        int sonuc = Topla(a, b);
        Console.WriteLine(sonuc);

        // Metotlar isimli bir sınıf oluşturma ve bir nesne oluşturma
        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));   // EkranaYazdir isimli metoda bir string değer gönderme

        int sonuc1 = ornek.ArttirVeTopla(ref a,ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc1));
    }

    static int Topla(int deger1, int deger2)
    {
        return deger1 + deger2;
    }
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int deger1, ref int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }
}


/*

Referans (ref) Anahtar Kelimesi:
Bir parametreyi referans olarak göndermek, metodun parametreye atanan değeri değiştirerek orijinal değişkenin değerini de değiştirmesi anlamına gelir.
* ArttirVeTopla metodunda ref anahtar kelimesi kullanıldığı için, metot içinde a ve b değişkenlerinin değerleri değiştirildiğinde,
Main metodundaki a ve b değişkenlerinin değerleri de değişir.

Değer Tipi ve Referans Tipi:

Değer Tipi: 
* Değişkenin kendisi bellekte tutulur. 
* Bir metota değer olarak gönderildiğinde, metodun içinde yapılan değişiklikler orijinal değişkeni etkilemez.
* Örneğin: int, double, bool

Referans Tipi:
* Değişkenin adresi bellekte tutulur.
* Bir metota referans olarak gönderildiğinde, metodun içinde yapılan değişiklikler orijinal değişkeni etkiler.
* Örneğin: sınıflar, diziler

*/
