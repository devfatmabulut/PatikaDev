// Implicit  Conversion (Biliçsiz Dönüşüm)
// Küçükten büyüğe dönüşüm + işlem gerektirmez
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a+b+c;  
Console.WriteLine("d: "+d); // output : 45

long h = d;
Console.WriteLine("h: "+h); 

float i = h ;
Console.WriteLine("i: "+i);

string e = "Fatma";
char f : 'a';
object g = e+f+d;
Console.WriteLine("g: "+g);


// Expilicit Conversion (Biliçli Dönüşüm)
// C# kendisinin gerekleştirmediği dönüşümler + Convert, Parse vb kullandığımız müdahale ettiğiimiz dönüşümler.

int x = 4;
// byte y = x -> hata 
byte y = (byte)x; // parantez içesine hedef veri türünü yazarsak sağdaki veriyi parantez içerisindeki veri türüne dönüştürmeye çalışır.
Console.WriteLine("y: "+y); // output : 4

int z = 100;
byte t = (byte)z;
Console.WriteLine("t: "+t); // output  : 100

float w =10.3f ;
byte v=(byte)w;
Console.WriteLine("v:" + v );  // output : 10

// ToString Metodu 

int xx  = 6;
string yy = xx.ToString();
Console.WriteLine("yy:" + yy );  // output : 6

string zz = 12.5f.ToString();
Console.WriteLine("zz:" + zz );  // output : 12.5

// System.Convert

string s1 = 10 , s2 = 20;
int sayi1, sayi2;
int Toplam ;
sayi1= Convert.ToInt32(s1);
sayi2= Convert.ToInt32(s2);

Toplam = sayi1 +sayi2;
Console.WriteLine(Toplam); // output : 30

// Parse
// string ifadeleri dönüştürmek için kullanılır ve her zaman string alır.

ParseMetod();

public static void ParseMetod()
{
    string metin1 = "10";
    string metin2 = "10.25";
    int rakam;
    double double1;

    rakam1 = Int32.Parse(metin1);   
    double1 = double.Parse(metin2);

     Console.WriteLine(rakam1);  // output : 10
      Console.WriteLine(double1) ;  // output : 10.25

}

