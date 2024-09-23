string namn1 = "";
string namn2 = "";
bool namn1val = false;
bool restart = false;

Console.WriteLine("Välkommen, vänligen skriv ditt spelarnamn.");

while (namn1val == false)
{
    namn1 = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(namn1))   //Ifall userinput inte är något (alltså null), så går det inte att gå framåt vilket betyder att man måste skriva sitt namn
    {
        Console.WriteLine("Nej. Gör om, gör rätt");
    }
    else 
    {
        Console.WriteLine($"Välkommen {namn1}, tryck på enter för att gå vidare!");
        Console.ReadLine();
        namn1val = true;
        restart = true;
    }
}

Random namngenerator = new Random();
int namn2val = 0;
namn2val = Random.Shared.Next(1, 4); //Slumpar ett tal från 1-3 vilket resulterar i 3 olika namn
if (namn2val == 1)
{
    namn2 = "Jonas";  
}
else if (namn2val == 2)
{
    namn2 = "Skeeby-dee";
}
else
{
    namn2 = "Konstantin Opel";
}



while (restart == true)
{


    int hp1 = 100;
    int hp2 = 100;

    Random dmggenerator = new Random();

    Console.Clear();

    Console.WriteLine($"Idag ska två deltagare vid namn {namn1} och {namn2} slåss, deltagarna startar med 100 hp.");
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
        Environment.Exit(0);           //ifall spelaren ej vill köra om programmet så stängs konsolen ner
    }
}


Console.ReadLine();