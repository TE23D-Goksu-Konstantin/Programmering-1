string namn1 = "Bertil";
string namn2 = "Jonas";

int hp1 = 100;
int hp2 = 100;

Random generator = new Random();

Console.WriteLine("Idag ska två deltagare vid namn Bertil och Jonas slåss, deltagarna startar med 100 hp.");
Console.WriteLine("Tryck på enter för att starta striden!");

Console.ReadLine();

while (hp1 > 0 && hp2 > 0)
{


    int dmg = Random.Shared.Next(33);
    hp1 -= dmg;
    Console.WriteLine($"{namn1} gjorde {dmg} skada på {namn2}");
    
    
    dmg = Random.Shared.Next(34);
    hp2 -= dmg;
    Console.WriteLine($"{namn2} gjorde {dmg} skada på {namn1}");

    Console.WriteLine("");
    Console.WriteLine($"{namn1}: {hp1}hp");
    Console.WriteLine($"{namn2}: {hp2}hp");

    Console.WriteLine("_.- Tryck på Enter för att starta en ny runda -._");
    Console.ReadLine();
 
}

Console.WriteLine("Slut, tryck på enter för att fortsätta");
Console.ReadLine();

if (hp1 <= 0)
{
    Console.WriteLine($"{namn2} har segrat med {hp2} återstående hp");
}
else if (hp2 <= 0)
{
    Console.WriteLine($"{namn1} har segrat med {hp1} återstående hp");
}
else 
{
    Console.WriteLine($"Det blev oavgjort");
}

Console.ReadLine();