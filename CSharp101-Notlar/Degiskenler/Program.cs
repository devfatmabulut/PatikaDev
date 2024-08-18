Console.WriteLine("");
string degisken = " "; // white spaceler hataya açıktır dikkatli olunmalı

byte b = 5 ;     // 1 byte yer kaplar   0 - 255 arası sayıları tutar
sbyte sb = 5;    // 1 byte yer kaplar  -128 - 127 arası sayıları tutar

short s = 5 ;     // 2 byte yer kaplar tam sayı değeri tutar
ushort us = 5;   // 2 byte yer kaplar tam sayı değeri tutar

Int16 i16 = 2 ;  // 2 byte
int i = 2 ;      // 4 byte
Int32 i32 = 2 ;  // 4 byte
Int64 i64 = 2 ;  // 8 byte

uint ui = 2;    // 4 byte 
long l = 4 ;    // 8 byte
ulong ul = 4 ;  // 8 byte

float f = 5;     // reeal sayı tutan veri tipi  4 byte
double d = 5;    // 8 byte 
decimal de = 5;  // 16 byte

char ch = '2';           // 2 byte tek karakter tutar
string str ="Fatma";    // sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now; // tarih tutar yazdırdığımız andaki tarih ve saat verisini verir

// object her türden veriyi ataya bildiğimiz bir çeşit üst türdür.
object o1 = "x";    // string
object o2 = 'y';    // char
object o3 = 4;      // int
object o4 = 4.3;    // decimal
object o5 = true;   // boolean

// string ifadeler
string str1 = string.Empty;
str1 = "Fatma Bulut";
string ad = "Fatma";
string soyad = "BULUT";
string tamIsim = ad + " " + soyad ;

// integer tanımlama şekilleri

int integer1 = 5 ; 
int integer2 = 3;
int integer3 = integer1 + integer2 ;

// boolean 

bool bool1 = 10>2;

// Değişken Dönüşümleri
string str20 = "20";
int int20 = 20 ;

string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);  // output : 2020

int int21 = int20 + Convert.ToInt32(str20) ; 
Console.WriteLine(int21); // output : 40

// datetime 

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

// saat 

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);

/*  Değişkenler

    Değişken tanımlama yapısı : (Değişken Türü) (Değişken Adı) = (Değeri)

 Değişken tanımlarken dikkat edilmesi gereken bazı hususlar şu şekilde:

    * Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
    * Değişken isimleri rakamlarla başlayamaz.
    * Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
    * Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
    * Class namespace gibi özel isimler kullanılamaz.
    * Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır. Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.
*/




