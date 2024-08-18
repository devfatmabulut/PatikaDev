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

// Insert
