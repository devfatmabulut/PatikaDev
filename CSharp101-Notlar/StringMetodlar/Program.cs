// String Metodlar - Hazır Metodlar

string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
string degisken2 = "CSharp";

//Length
System.Console.WriteLine(degisken.Length);

//ToUpper, ToLower
System.Console.WriteLine(degisken.ToUpper());
System.Console.WriteLine(degisken.ToLower());

//Concat 
//- Birleştirir
System.Console.WriteLine(String.Concat(degisken," Merhaba,"));

// Compare , Compare to -> karşılaştırma
System.Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1
// * 1. değişken 2. değişkene eşit olursa bana 0 döndürür, 
// * 1.degisken, 2. değişkenden daha büüyük bir karakter sayısına sahipse bana 1 döndürür.
// eğer 1.değişken 2. değişkenden daha küçük bir karakter sayısına sahipse bana -1 döndürür.

System.Console.WriteLine(String.Compare(degisken,degisken2,true)); 
System.Console.WriteLine(String.Compare(degisken,degisken2,false)); 
// true :  büyük küçük harf duyarsızdır
// false : büyük küçük harf duyarlıdır.

//Constains -> içerme / içermeme durumu 
System.Console.WriteLine(degisken.Contains(degisken2));  // içinde varmı
System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); // ... bitiyor mu ?
System.Console.WriteLine(degisken.StartsWith("Merhaba")); // ... başlıyor mu ?

//IndexOf -> İlk bulduğu yerdeki ilk indexi verir bulamazsa -1 döner
System.Console.WriteLine(degisken.IndexOf("CS"));
System.Console.WriteLine(degisken.IndexOf("f"));
System.Console.WriteLine(degisken.LastIndexOf("i")); // son indexi

// Insert
System.Console.WriteLine(degisken.Insert(0,"Merhaba! "));

//PadLeft ,PadRight
System.Console.WriteLine(degisken+degisken2.PadLeft(30)); // değişken2 nin sonuna uznuluğu 30 olacak kadar boşluk ekler
System.Console.WriteLine(degisken.PadRight(50)+degisken2); // değişken1 in sonuna uznuluğu 50 olacak kadar  boşluk ekler
System.Console.WriteLine(degisken.PadRight(50)+degisken2.PadLeft(30,'*')); 

// Remove
// silme
System.Console.WriteLine(degisken.Remove(10)); // 10.karakterden sonrasını siler
System.Console.WriteLine(degisken.Remove(5,3)); // 5 den başlar 3 karakter siler.
System.Console.WriteLine(degisken.Remove(0,1)); // 0 dan başlar  1 karakter siler. ilk harfi

// Replace
System.Console.WriteLine(degisken.Replace("CSharp","C#")); // değiştirme
System.Console.WriteLine(degisken.Replace(" ","*")); // değiştirme

// Split** 
System.Console.WriteLine(degisken.Split(' ')[1]); // boşluklara göre parçala bir diziye ata bana 1. indexteki veriyi bana getir

// Sunstring
System.Console.WriteLine(degisken.Substring(4)); // 4. indexten başlar sonuna kadar getirir.
System.Console.WriteLine(degisken.Substring(4,6)); // 4. indexten başlar 6 karakter getir.

