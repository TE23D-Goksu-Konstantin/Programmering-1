int plånbok = 100;
string val;
bool klar = false;
int val2;
string antalv;
int antal;
bool butik = false;
bool status = false;

int boke = 0;
int yxe = 0;
int pew = 0;

Console.WriteLine("""
____________________________________________
|__________________Big__Store________________|
|__||  ||___||  |_|___|___|__|  ||___||  ||__|
||__|  |__|__|  |___|___|___||  |__|__|  |__||
|__||  ||___||  |_|___|___|__|  ||___||  ||__|
||__|  |__|__|  |    || |    |  |__|__|  |__||
|__||  ||___||  |    || |    |  ||___||  ||__|
||__|  |__|__|  |    || |    |  |__|__|  |__||
|__||  ||___||  |    || |    |  ||___||  ||__|
||__|  |__|__|  |    || |    |  |__|__|  |__||
|__||  ||___||  |   O|| |O   |  ||___||  ||__|
||__|  |__|__|  |    || |    |  |__|__|  |__||
|__||  ||___||  |    || |    |  ||___||  ||__|
||__|  |__|__|__|____||_|____|  |__|__|  |__||
|LLL|  |LLLLL|______________||  |LLLLL|  |LLL|
|LLL|  |LLL|______________|  |  |LLLLL|  |LLL|
|LLL|__|L|______________|____|__|LLLLL|__|LLL|
""");
Thread.Sleep(1000);
Console.Clear();

while(plånbok > 0)
{
    Console.WriteLine("Välkommen till min extraordinära butik som har allt från böcker till makingevär!");
    Console.WriteLine($"Du har just nu {plånbok}kr, tryck på enter för att gå vidare till butiken");
    Console.ReadLine();
    Console.Clear();
    Thread.Sleep(200);
    Console.WriteLine(""" 
    █▒▒▒▒▒▒▒▒▒
    """);
        Thread.Sleep(1000);
        Console.Clear();
    Console.WriteLine("""
    ████▒▒▒▒▒▒
    """);
        Thread.Sleep(300);
        Console.Clear();
    Console.WriteLine("""
    █████▒▒▒▒▒
    """);
        Thread.Sleep(700);
        Console.Clear();
    Console.WriteLine("""
    ████████▒▒
    """);
        Thread.Sleep(1000);
        Console.Clear();
    Console.WriteLine("""
    ██████████
    """);
    Thread.Sleep(100);
    Console.Clear();
    butik = true;

    if(butik == true)
    {
    Console.WriteLine("Bok: 10kr");
    Console.WriteLine("Tryck på 1 för att köpa en bok");
    Console.WriteLine("");
    Console.WriteLine("Yxa: 20kr");
    Console.WriteLine("Tryck på 2 för att köpa en yxa");
    Console.WriteLine("");
    Console.WriteLine("PPSH-41: 40kr");
    Console.WriteLine("Tryck på 3 för att köpa en PPSH-41");
    Console.WriteLine("");
    Console.WriteLine("""Tryck på "N" för att stänga programmet""");
    butik = false;
    }
 

    val = Console.ReadLine();
    int.TryParse(val, out val2);
        Console.Clear();
    Thread.Sleep(400);
    Console.WriteLine(""" 
    █▒▒▒▒▒▒▒▒▒
    """);
        Thread.Sleep(300);
        Console.Clear();
    Console.WriteLine("""
    ████▒▒▒▒▒▒
    """);
        Thread.Sleep(600);
        Console.Clear();
    Console.WriteLine("""
    █████▒▒▒▒▒
    """);
        Thread.Sleep(200);
        Console.Clear();
    Console.WriteLine("""
    ████████▒▒
    """);
        Thread.Sleep(500);
        Console.Clear();
    Console.WriteLine("""
    ██████████
    """);
    Thread.Sleep(100);
    Console.Clear();

    if(val2 >= 4)
    {
    Console.WriteLine("Nae du, gör om gör rätt");
    string nyval = Console.ReadLine();
    int.TryParse(nyval, out val2);
    }


    if(val2 == 1)
    {
        Console.Clear();
        Console.WriteLine("Du har valt att köpa en bok, hur många exemplar vill du köpa?");
        Console.WriteLine($"Boken kostar 10kr/st och du har {plånbok}kr");
        antalv = Console.ReadLine();
        int.TryParse(antalv, out antal);
        int kostnad = antal*10;

        if (kostnad <= plånbok)
        {
            plånbok -= kostnad;
            boke += antal;
        }
        else
        {
            Console.WriteLine("Nej, du har inte råd med detta köp");
            Console.ReadLine();
            butik = true;
        }
    }

    if(val2 == 2)
    {
        Console.Clear();
        Console.WriteLine("Du har valt att köpa en yxa, hur många exemplar vill du köpa?");
        Console.WriteLine($"Yxan kostar 20kr/st och du har {plånbok}kr");
        antalv = Console.ReadLine();
        int.TryParse(antalv, out antal);
        int kostnad = antal*20;

        if (kostnad <= plånbok)
        {
            plånbok -= kostnad;
            yxe += antal;
        }
            else
        {
            Console.WriteLine("Nej, du har inte råd med detta köp");
            Console.ReadLine();
            butik = true;
        }
    }

    if(val2 == 3)
    {
        Console.Clear();
        Console.WriteLine("Du har valt att köpa en PPSH-41, hur många exemplar vill du köpa?");
        Console.WriteLine($"PPSH-41 kostar 40kr/st och du har {plånbok}kr");

                antalv = Console.ReadLine();
        int.TryParse(antalv, out antal);
        int kostnad = antal*40;

        if (kostnad <= plånbok)
        {
            plånbok -= kostnad;
            pew += antal;
        }
            else
        {
            Console.WriteLine("Nej, du har inte råd med detta köp");
            Console.ReadLine();
            butik = true;
        }
    }
}


if(plånbok == 0)
{
        Console.Clear();
    Thread.Sleep(200);
    Console.WriteLine(""" 
    █▒▒▒▒▒▒▒▒▒
    """);
        Thread.Sleep(500);
        Console.Clear();
    Console.WriteLine("""
    ████▒▒▒▒▒▒
    """);
        Thread.Sleep(300);
        Console.Clear();
    Console.WriteLine("""
    █████▒▒▒▒▒
    """);
        Thread.Sleep(600);
        Console.Clear();
    Console.WriteLine("""
    ████████▒▒
    """);
        Thread.Sleep(1000);
        Console.Clear();
    Console.WriteLine("""
    ██████████
    """);
    Thread.Sleep(50);
    Console.Clear();
    Console.WriteLine("D");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du h");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du ha");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har ");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har s");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har sl");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slu");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut p");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på ");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på p");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pe");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pen");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på peng");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på penga");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar ");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar o");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar oc");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och ");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och l");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lä");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och läm");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämn");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämna");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar ");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar b");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar bu");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar but");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar buti");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar butik");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar butike");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar butiken");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar butiken.");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar butiken..");
        Thread.Sleep(100);
    Console.Clear();
    Console.WriteLine("Du har slut på pengar och lämnar butiken...");
    
    Thread.Sleep(2300);
    Console.Clear();
        Console.WriteLine($"D");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du ");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du h");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du ha");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du ha");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har ");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har k");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har kö");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köp");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt");
    Thread.Sleep(200);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} ");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} b");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} bö");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böc");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böck");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcke");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker,");
    Thread.Sleep(200);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} ");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} y");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yx");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxo");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor o");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor oc");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och");
    Thread.Sleep(200);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} ");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} P");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PP");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPS");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH-");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH-4");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH-41");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH-41.");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH-41..");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH-41...");
    Thread.Sleep(100);
    Console.Clear();
        Console.WriteLine($"Du har köpt {boke} böcker, {yxe} yxor och {pew} PPSH-41....");
    Thread.Sleep(3000);
    Console.Clear();
        Console.WriteLine("V");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Vä");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Väl");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välk");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välko");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkom");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkomm");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkomme");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen å");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen åt");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen åte");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen åter");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen åter -");
        Thread.Sleep(200);
        Console.Clear();

        Console.WriteLine("Välkommen åter - L");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen åter - Lu");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen åter - Lud");
        Thread.Sleep(100);
        Console.Clear();

 
        Console.WriteLine("Välkommen åter - Ludv");
        Thread.Sleep(100);
        Console.Clear();

        Console.WriteLine("Välkommen åter - Ludvi");
        Thread.Sleep(100);
        Console.Clear();


        Console.WriteLine("Välkommen åter - Ludvig");
        Thread.Sleep(100);

    Thread.Sleep(3000);
    
    Console.WriteLine("""
    

                     _______
              ,,--''         ''--,,
           ,-'                     '-,
          /                           \
          |                           |
          |                           |
          | |\                     /| |
     |\   | | \                   / | |   /|
     | \  | |  '-,             ,-'  | |  / |
     |  '-| |     '-,       ,-'     | |-'  |
     |      |        \     /        |      |
     |      |    ,-;;/     \;;-,    |      |
     |  ,'   \__|;;;/ ,   , \;;;|__/   ',  |
      \/              |   |              \/
      /             ,-|   |-,             \
      ;             \       /             ;
       \             '-, ,-'             /
        '-,,            '            ,,-'
            '-,    \'-,           ,-'
               ',   \  ''--,,   ,'
                 \   ''--,, /  /
                 |\           /|
                 |(           )|
                 |'-,       ,-'|  
                     ''-,-'' 


    """);
    Thread.Sleep(30);
    Environment.Exit(0);
    }



