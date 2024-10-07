int plånbok = 100;
string val;
bool klar = false;
int val2;
string antalv;
int antal;
bool butik = false;
bool status = false;


while(plånbok >= 0 && status == false)
{
    Console.WriteLine("Välkommen till min extraordinära butik som har allt från böcker till makingevär!");
    Console.WriteLine($"Du har just nu {plånbok}kr, tryck på enter för att gå vidare till butiken");
    Console.ReadLine();
    Thread.Sleep(1000);
    Console.Clear();
    butik = true;

    if(butik == true)
    {
    Console.WriteLine("Bok: 10kr");
    Console.WriteLine("Tryck på 1 för att köpa en bok");
    Console.WriteLine("");
    Console.WriteLine("Yxa: 23kr");
    Console.WriteLine("Tryck på 2 för att köpa en yxa");
    Console.WriteLine("");
    Console.WriteLine("PPSH-41: 40kr");
    Console.WriteLine("Tryck på 3 för att köpa en PPSH-41");
    Console.WriteLine("");
    butik = false;
    }
 

    val = Console.ReadLine();
    int.TryParse(val, out val2);

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
        antal = antal*10;
        if(antal > 100)
        {
            Console.WriteLine("Nej, du har inte råd med detta köp");
            Console.ReadLine();
            butik = true;
        }
        plånbok -= antal;
    }

    if(val2 == 2)
    {
        Console.Clear();
        Console.WriteLine("Du har valt att köpa en yxa, hur många exemplar vill du köpa?");
        Console.WriteLine($"Yxan kostar 10kr/st och du har {plånbok}kr");
    }

    if(val2 == 3)
    {
        Console.Clear();
        Console.WriteLine("Du har valt att köpa en PPSH-41, hur många exemplar vill du köpa?");
        Console.WriteLine($"PPSH-41 kostar 10kr/st och du har {plånbok}kr");
    }
}


