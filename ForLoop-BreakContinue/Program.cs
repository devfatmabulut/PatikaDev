// For Loop ve Break Continue Ifadeleri

Console.WriteLine("Lütfen sayı giriniz  :");
int sayi = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= sayi ; i++)
{
    if(i%2==1)
     Console.WriteLine("Tek sayılar : "+i);
    
}

// 1 ile 100 arasındaki tek sayılar ve çift sayıların toplamları nedir?

int tekToplam = 0;
int ciftToplam = 0;

for(int i = 1 ; i <=1000; i++)
{
    if(i%2==0){
        tekToplam += i; // tektoplam = tektoplam +i;

    }
    else{
        ciftToplam += i;
    }
}
Console.WriteLine("Tek sayıların toplamı = "+ tekToplam);
Console.WriteLine("Çift sayıların toplamı = "+ ciftToplam);

// Break & Countinue

for(int i = 1 ; i < 10 ; i++)
{
    if(i==4)
        break;
    Console.WriteLine(i);  // output : 1 2 3  -> 4ü dahil etmedi ve durdu.
}


for(int i = 1 ; i < 10 ; i++)
{

    if(i==4)
        continue;
    Console.WriteLine(i);  // output : 1 2 3 5 6 7 8 9  -> 4ü dahil etmedi ve devam etti
}


