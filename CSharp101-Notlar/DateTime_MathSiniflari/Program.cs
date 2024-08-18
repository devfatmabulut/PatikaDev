// Date Time ve Math Kütüphaneleri
System.Console.WriteLine(DateTime.Now); // bugün
System.Console.WriteLine(DateTime.Now.Date); // gün/ay/yıl
System.Console.WriteLine(DateTime.Now.Day); //gün
System.Console.WriteLine(DateTime.Now.Month); // ay
System.Console.WriteLine(DateTime.Now.Year); // yıl
System.Console.WriteLine(DateTime.Now.Hour); // saat
System.Console.WriteLine(DateTime.Now.Minute); // dk
System.Console.WriteLine(DateTime.Now.Second); // sn

System.Console.WriteLine(DateTime.Now.DayOfWeek); // hafta
System.Console.WriteLine(DateTime.Now.DayOfYear); // yılın kacıncı günündeyiz

System.Console.WriteLine(DateTime.Now.ToLongDateString()); // 19 Agustos 2024 Pazartesi
System.Console.WriteLine(DateTime.Now.ToShortDateString()); // 19.08.2024
System.Console.WriteLine(DateTime.Now.ToShortTimeString()); // 01:16
System.Console.WriteLine(DateTime.Now.ToLongTimeString()); // 01:16:54

System.Console.WriteLine(DateTime.Now.AddDays(2)); // 21.08.2024 01:20:20
System.Console.WriteLine(DateTime.Now.AddHours(3)); //19.08.2024 04:20:20
System.Console.WriteLine(DateTime.Now.AddSeconds(30)); // 19.08.2024 01:20:50
System.Console.WriteLine(DateTime.Now.AddMonths(5)); // 19.01.2025 01:20:20
System.Console.WriteLine(DateTime.Now.AddYears(10)); // 19.08.2034 01:20:20
System.Console.WriteLine(DateTime.Now.AddMilliseconds(50)); // 19.08.2024 01:20:20

// Datetime Format
System.Console.WriteLine(DateTime.Now.ToString("dd")); // 19
System.Console.WriteLine(DateTime.Now.ToString("ddd")); // Pzt
System.Console.WriteLine(DateTime.Now.ToString("dddd")); // Pazartesi

System.Console.WriteLine(DateTime.Now.ToString("MM")); // 08
System.Console.WriteLine(DateTime.Now.ToString("MMM")); // Agu
System.Console.WriteLine(DateTime.Now.ToString("MMMM")); // Agustos

System.Console.WriteLine(DateTime.Now.ToString("yy")); //24
System.Console.WriteLine(DateTime.Now.ToString("yyy")); // 2024

System.Console.WriteLine("Math Kütüphanesi");

// Math Kütüphanesi
System.Console.WriteLine(Math.Abs(-25)); // Mutlak değer
System.Console.WriteLine(Math.Sin(10)); // Sinus
System.Console.WriteLine(Math.Cos(10)); // Cosinus
System.Console.WriteLine(Math.Tan(10)); // Tanjant

System.Console.WriteLine(Math.Ceiling(22.3)); //  Double en yakın büyük
System.Console.WriteLine(Math.Round(22.3)); // 05. ten sonra en yakın 
System.Console.WriteLine(Math.Round(22.7)); // 05. ten sonra en yakın 
System.Console.WriteLine(Math.Floor(22.3)); // en yakın küçük


System.Console.WriteLine(Math.Min(2,6)); //  küçük değer
System.Console.WriteLine(Math.Max(2,6)); // büyük değer

System.Console.WriteLine(Math.Pow(3,4)); // 2^4
System.Console.WriteLine(Math.Sqrt(9)); // karekök alır -> 3
System.Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logoritmik karşılığı
System.Console.WriteLine(Math.Exp(3)); // e üzeri 3 verir
System.Console.WriteLine(Math.Log10(10)); // 10 sayısısnın logoritma1 tabanındaki karşılığı







