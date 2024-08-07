// While-Foreach 

// 1 den başlayarak girdiğimiz sayıya kadar sayı dahil ortalama hesaplama

Console.WriteLine("Bir sayı giriniz  :");
int sayi = Convert.ToInt32(Console.ReadLine());
int sayac = 1;
int toplam = 0;
 while(sayac <= sayi) // koşul true oldukç çalışır
 {
    toplam += sayac;
    sayac ++; // eklemezsek sonsuz döner 

 }
 Console.WriteLine(toplam/sayi);

 // 'a' dan 'z' ye kadar tüm harfleri consoele yazdır

char caracter = 'a';
while (caracter < 'z')
{
   Console.Write(caracter);
   caracter ++;
}

Console.WriteLine(caracter); // output : abcdefghijklmnopqrstuvwxyz

// Foreach 

string [] arabalar = {"bmw", "ford","toyota", "nissan"};

foreach ( var araba in arabalar)
{
   Console.WriteLine(araba); // output : bmw
                                      // ford
                                      // toyota
                                      // nissan
} 