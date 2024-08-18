

// Try Catch Finally ve Mantıksal Hatalar

try //hataya neden olabilecek kodu yazıyoruz
{
    int a = int.Parse(null);
}
catch(Exception ex) // hatamı yakaldığımda ne yapmak istiyorsam onu yazıyorum
{
    Console.WriteLine("Hata : "+ ex.Message.ToString());
    Console.WriteLine(ex);
}
Finally // Hatadan bağımsız çalışmasını istediğimiz şeyleri yazıyoruz. Zorunlu değii(optional) isterseniz finally kullanmak zorunda değiliz.
{
    Console.WriteLine("İşlem Tamamlandı");   
}

// ArgumentNullException
try
{
    int a = int.Parse(null);
}
catch(ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}

// FormatException
try
{
    int a = int.Parse("test");
}
catch(FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil");
    Console.WriteLine(ex);
}

// OwerflowException

try
{
    int a = int.Parse("-20000000000000");
}
catch(OwerflowException ex)
{
    Console.WriteLine(" Çok büyük yada çok büyük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("işlem başarı ile tamamlandı");
}


