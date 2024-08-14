// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
// Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

// Console.WriteLine("Lütfen Pozitif bir sayı giriniz : ");
// int n = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Girdiğiniz sayı  : "+ n);

// for (int i = 0; i <= n; i++)
// {
//    if (i%2==0)
//    {
//     Console.WriteLine(i);
//    }
// }

//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. + 

// Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

// Console.WriteLine("lütfen 2 adet pozitif sayı giriniz");
// Console.WriteLine("lütfen birinci sayıyı giriniz");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("lütfen ikinci sayıyı giriniz");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] atama = new int[n];
// Console.WriteLine($"Lütfen {n} adet pozitif tam sayı giriniz:");
// for (int i = 0; i < n; i++)
// {
//     if (i >= 0)
//     {
//         Console.Write($"{i + 1}. Sayı : ");
//         atama[i] = Convert.ToInt32(Console.ReadLine());
//     }

// }


//Console.WriteLine($"Girilen sayılar içinde {m}'ye eşit veya tam bölünenler: ");
//foreach (int item in atama)
//{
//    if (item == m || item % m == 0)
//    {
//        Console.WriteLine(item + " ");
//    }
//}

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (t).
// Sonrasında kullanıcıdan t adet kelime girmesi isteyin. 
// Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

// Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
// int t = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Lütfen {t} tane kelime giriniz.");
// string[] kelimeler = new string[t];

// for (int i = 0; i < t; i++)
// {
//     if (i >= 0)
//     {
//         Console.Write($"{i + 1}. Kelime : ");
//         kelimeler[i] = Console.ReadLine().ToString();
//     }

// }

// Console.WriteLine("Kelimeler sondan başa doğru:");
// for (int i = t - 1; i >= 0; i--)
// {
//     Console.Write(kelimeler[i] + " ");
// }

//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

// Console.WriteLine("Lütfen bir cümle giriniz : ");
// string cumle = Console.ReadLine();
// System.Console.WriteLine("Harf sayısı : " + cumle.Length);

// int kelimeSayisi = cumle.Trim().Split(' ').Length;
// System.Console.WriteLine("Kelime sayısı  : " + kelimeSayisi);







