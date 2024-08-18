// Swich- Case

int month = DateTime.Now.Month;

// Expression
switch (month)
{
    case 1:
        Console.WriteLine("Ocak ayındasınız.");
        break;
    case 2 :
        Console.WriteLine("Şubat ayındasınız.");
        break;
    case 6:
    case 7:
    Console.WriteLine("YAZ MEVSİMİNDESİNİZ");
    case 8:
        Console.WriteLine("Ağustos ayındasınız.");
        break;
    default:
        Console.WriteLine("Yanlış veri girişi.");
    break;
}
