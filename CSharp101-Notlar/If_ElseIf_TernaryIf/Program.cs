

int time = DateTime.Now.Hour;

if(time<=6 && time < 11)
{
   Console.WriteLine("Günaydın! "); 
}
else if(time <= 18)
{
    Console.WriteLine("İyi Günler!");
}
else
{
    Console.WriteLine( "İyi Geceler")
}

// ternary if -> tek satır if 
// ? ise
// : değilse 

string sonuc = time<=18 ? "iyi günler" : "iyi geceler";
Console.WriteLine(sonuc);

// Console.WriteLine(string sonuc = time<=18 ? "iyi günler" : "iyi geceler";);
