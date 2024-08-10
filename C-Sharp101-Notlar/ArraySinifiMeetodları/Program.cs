C#
// Dizi tanımlama
int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

Console.WriteLine("**** Sırasız Dizi ****");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

// Diziyi sıralama
Console.WriteLine("**** Sıralı Dizi ****");
Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

// Diziyi temizleme (2. indexten başlayarak 2 elemanı 0 ile değiştirme)
Console.WriteLine("**** Array Clear ****");
Array.Clear(sayiDizisi, 2, 2);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

// Diziyi ters çevirme
Console.WriteLine("**** Array Reverse ****");
Array.Reverse(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("**** Array IndexOf ****");
Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

Console.WriteLine("**** Array Resize ****");
Array.Resize<int>(ref sayiDizisi, 9);
sayiDizisi[8] = 99;

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

