static void spel(){
    


bool question = false;
int p = 0;
string svar = "";

Console.WriteLine("Välkommen till Andra Världskriget Quiz om Tyskland! Idag ska du svara på 6 st frågor. Tryck på en valfri tangent för att starta,  lycka till!");
Console.ReadLine();

Console.WriteLine("Vilken höguppsatt tysk officerare hade en sjukdom som bröt mot tyskarnas egna filosofi om genetik?");
Console.WriteLine("[1] Heinrich Himmler");
Console.WriteLine("[2] Erwin Göring");
Console.WriteLine("[3] Joseph Goebbels");
svar = Console.ReadLine();
if (svar.Equals("3", StringComparison.CurrentCultureIgnoreCase))             //Använda quick fix för min struktur "if (svar.ToLower() == "3") fungerade ej, den räknade inte poängen.
{
    p++;
}

Console.WriteLine("Vad kallades tyskarnas trupper i Afrika under andra världskriget?");
Console.WriteLine("[1] Volkssturm");
Console.WriteLine("[2] Afrika Korps");
Console.WriteLine("[3] Africa Erzattstruppen");
svar = Console.ReadLine();
if (svar.Equals("2", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Vilken pansarvagn var PanzerKampfVagen V?");
Console.WriteLine("[1] Panther");
Console.WriteLine("[2] Tiger");
Console.WriteLine("[3] Nashorn");
svar = Console.ReadLine();
if (svar.Equals("1", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Vad kallades invationen av Sovjet Unionen av Tyskarna");
Console.WriteLine("[1] Operation Vanguard");
Console.WriteLine("[2] Operation Danzig");
Console.WriteLine("[3] Operation Barbarossa");
svar = Console.ReadLine();
if (svar.Equals("3", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Vad kallades legenden vilket hjälpte Adolf Hitler att komma till makten");
Console.WriteLine("[1] Dolkstötslegenden");
Console.WriteLine("[2] Frihetslegenden");
Console.WriteLine("[3] Domens-dag legenden");
svar = Console.ReadLine();
if (svar.Equals("1", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Kunde Tyskarna ha vunnit kriget?");
Console.WriteLine("[1] Ja");
Console.WriteLine("[2] Nej");
svar = Console.ReadLine();
if (svar.Equals("2", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
    question = true;
}


if (question == true & p > 3)
{
Console.WriteLine("Bra jobbat! Du fick mer än 50% korrekt.");
Console.ReadLine();
}
else if(question == true & p < 3)
{
Console.WriteLine("Ja du, det gick inte så bra. Mindre än 50% rätt, återuppta historia lektionerna nu.");
Console.ReadLine();
}
else if(question == true || p == 0)
{
Loser();             //hämtar informationen från static void funktionen längre ner i koden
}
else
{
Console.WriteLine("Okej, 50% rätt. Varken bra eller dåligt, kämpa på så är du nästan där!");
Console.ReadLine();
}

}

spel();
Console.WriteLine("Vill du spela om?");
string svar2 = Console.ReadLine();
if (svar2.Equals("Ja", StringComparison.CurrentCultureIgnoreCase))      //loop, frågar ifall man vill spela om
{
    spel();
}



static void Loser()
{

    Console.WriteLine("""
__________               __                          __   .__  __   
\______   \ ____   _____/  |_  _____ ___  __   _____|  | _|__|/  |_ 
 |       _// __ \ /    \   __\ \__  \\  \/ /  /  ___/  |/ /  \   __\
 |    |   \  ___/|   |  \  |    / __ \\   /   \___ \|    <|  ||  |  
 |____|_  /\___  >___|  /__|   (____  /\_/   /____  >__|_ \__||__|  
        \/     \/     \/            \/            \/     \/         
""");
Console.ReadLine();
}