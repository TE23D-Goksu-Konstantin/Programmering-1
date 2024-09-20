string namn1 = "Bertil";
string namn2 = "Jonas";

bool restart = true;
while (restart == true)
{


    int hp1 = 100;
    int hp2 = 100;

    Random generator = new Random();

    Console.Clear();

    Console.WriteLine("Idag ska två deltagare vid namn Bertil och Jonas slåss, deltagarna startar med 100 hp.");
    Console.WriteLine("Tryck på enter för att starta striden!");

    Console.ReadLine();

    while (hp1 > 0 && hp2 > 0)
    {

        Console.WriteLine("_.- Tryck på Enter för att starta en ny runda -._");
        Console.ReadLine();

        int dmg = Random.Shared.Next(33);           //slump mekanismen
        hp1 -= dmg;
        Console.WriteLine($"{namn2} gjorde {dmg} skada på {namn1}");


        dmg = Random.Shared.Next(34);
        hp2 -= dmg;
        Console.WriteLine($"{namn1} gjorde {dmg} skada på {namn2}");

        Console.WriteLine("");
        Console.WriteLine($"{namn1}: {hp1}hp");
        Console.WriteLine($"{namn2}: {hp2}hp");

    }

    Console.WriteLine("Slut, tryck på enter för att fortsätta.");
    Console.ReadLine();


    if (hp1 <= 0)
    {
        hp1 -= hp1;
    }
    if (hp2 <= 0)
    {       //ifall en av spelarna går under 0hp, alltså negativ så blir deras hp 0
        hp2 -= hp2;
    }


    if (hp1 == 0 && hp2 == 0)      //ifall båda har 0hp så blir det oavgjort
    {
        Console.WriteLine("Det blev oavgjort, ni båda suger lika mycket!");
    }
    else if (hp1 > 0)
    {
        Console.WriteLine($"{namn1} vann med {hp1} återstående hp!");
    }
    else if (hp2 > 0)
    {
        Console.WriteLine($"{namn2} vann med {hp2} återstående hp!");
    }

    Console.ReadLine();

    Console.WriteLine("Tryck på [y/n] för att spela om.");   //kollar ifall spelaren vill spela om spelet genom ett knapptryck
    ConsoleKeyInfo info = Console.ReadKey();
    if (info.Key == ConsoleKey.Y)
    {
        hp1 = 100;
        hp2 = 100;
    }
    else
    {
        _ = restart == false;
        Environment.Exit(0);
    }
}


Console.ReadLine();