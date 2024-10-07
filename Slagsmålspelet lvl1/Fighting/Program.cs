using Microsoft.VisualBasic;

string namn1 = "";
string namn2 = "";
bool namn1val = false;
bool restart = false;
int plånbok = 1000;
int bet = 0;
bool betting = true;

Thread.Sleep(1000); //timer, väntar 1 sekund innan den fortsätter

Console.WriteLine("""
     _                 _    __ _       _     _            
    | |               | |  / _(_)     | |   | |           
 ___| |_ _ __ ___  ___| |_| |_ _  __ _| |__ | |_ ___ _ __ 
/ __| __| '__/ _ \/ _ \ __|  _| |/ _` | '_ \| __/ _ \ '__|
\__ \ |_| | |  __/  __/ |_| | | | (_| | | | | ||  __/ |   
|___/\__|_|  \___|\___|\__|_| |_|\__, |_| |_|\__\___|_|   
                                  __/ |                   
                                 |___/                    
""");

Thread.Sleep(2000);

Console.Clear();

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
        //restart = true;
    }
}

Thread.Sleep(100);

Random namngenerator = new Random();
int namn2val = 0;
namn2val = Random.Shared.Next(1, 4); //Slumpar ett tal från 1-3 vilket resulterar i 3 olika namn
if (namn2val == 1)
{
    namn2 = "Jonas"; 
    Console.WriteLine("Din motståndare är,");
    Thread.Sleep(200);
    Console.WriteLine("3...");
    Thread.Sleep(500);
    Console.WriteLine("2...");
    Thread.Sleep(500);
    Console.WriteLine("1...");
    Thread.Sleep(500);
    Console.WriteLine($"{namn2} är din motståndare");
    Thread.Sleep(1000);
    Console.Clear();
}
else if (namn2val == 2)
{
    namn2 = "Skeeby-dee";
    Console.WriteLine("Din motståndare är,");
    Thread.Sleep(200);
    Console.WriteLine("3...");
    Thread.Sleep(500);
    Console.WriteLine("2...");
    Thread.Sleep(500);
    Console.WriteLine("1...");
    Thread.Sleep(500);
    Console.WriteLine($"{namn2} är din motståndare");
    Thread.Sleep(1000);
    Console.Clear();
}
else
{
    namn2 = "Konstantin Opel";
    Console.WriteLine("Din motståndare är,");
    Thread.Sleep(200);
    Console.WriteLine("3...");
    Thread.Sleep(500);
    Console.WriteLine("2...");
    Thread.Sleep(500);
    Console.WriteLine("1...");
    Thread.Sleep(500);
    Console.WriteLine($"{namn2} är din motståndare");
    Thread.Sleep(1000);
    Console.Clear();
}


    restart = true;



while (restart == true)
{


    int hp1 = 100;
    int hp2 = 100;

    Random dmggenerator = new Random();

    Console.Clear();

    while (betting == true)
{
    if (plånbok == 0)
    {
        Console.WriteLine($"Ser ut som att du har slut på pengar men du kan fortfarande spela utan att satsa");
        Thread.Sleep(4000);
        betting = false;
        Console.Clear();
    }
    else
    {
    Console.WriteLine($"Du har {plånbok}kr kvar, skriv in hur mycket du vill satsa på din spelare");
    String p = Console.ReadLine();
    int.TryParse(p, out bet);
    plånbok -= bet;
    betting = false;
    Console.Clear();
    }
}

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
        plånbok += bet*2;
        Console.WriteLine($"Du har nu {plånbok}kr");
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
        bet = 0;
        betting = true;
    }
    else
    {
        _ = restart == false;
        Environment.Exit(0);           //ifall spelaren ej vill köra om programmet så stängs konsolen ner
    }
}


Console.ReadLine();