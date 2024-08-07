// Atama Ve İşlemli Atama
int x = 3;
int y = 3;

y = y+2; 
Console.WriteLine(y); // output : 5 

y += 2; // (y = y+2 ile aynı ancak bu işlemli atama )
Console.WriteLine(y); // output : 7

y/= 1; //  output : 7
Console.WriteLine(y); // output : 7

x*= 2; 
Console.WriteLine(x); // output : 6

// Mantıksal Operatörler
// ||, &&, !

bool isSuccess = true ;
bool isCompleted = false ; 

if(isSuccess && isCompleted)
    Console.WriteLine("Perfect");

if(isSuccess || isCompleted)
    Console.WriteLine("Great");

if(isSuccess && !isCompleted)
    Console.WriteLine("Fine");

// İlişkisel Operatörler
// <, <, <=, >=, ==, =!

int a = 3;
int b=4;
bool sonuc = a<b;
Console.WriteLine(sonuc); // true

sonuc = a>b;
Console.WriteLine(sonuc); // false

sonuc = a>=b;
Console.WriteLine(sonuc); // false

sonuc = a>=b;
Console.WriteLine(sonuc); // true

sonuc= a==b;
Console.WriteLine(sonuc); // false 

sonuc= a!=b;
Console.WriteLine(sonuc); // true

// Aritmetik Operatörler
// /, *, + , - 

int sayi = 10;
int sayi2 = 5;

int sonuc1 =  sayi / sayi2;
Console.WriteLine(sonuc1); // 2

int sonuc1 =  sayi * sayi2;
Console.WriteLine(sonuc1); // 50

int sonuc1 =  sayi + sayi2;
Console.WriteLine(sonuc1); // 15

int sonuc1 =  sayi++;
Console.WriteLine(sayi); // 11

// % : mood alır
int sonuc2 = 20%3;
Console.WriteLine(sonuc2); // 2


