bool question = false;
int p = 0;
string svar = "";

Console.WriteLine("Välkommen till brainrot quiz! Idag ska du svara på 6 st frågor om brainrot. Tryck på en valfri tangent för att starta,  lycka till!");
Console.ReadLine();

Console.WriteLine("Vad kallas någon som inte behöver någon annan än sig själv för att bli den bästa versionen av sig själv? Beta, Alpha    eller Sigma");
svar = Console.ReadLine();
if (svar.Equals("Sigma", StringComparison.CurrentCultureIgnoreCase))             //Använda quick fix för min struktur "if (svar.ToLower() == "Sigma") fungerade ej, den räknade inte poängen.
{
    p++;
}

Console.WriteLine("Vad kallas den animerade toaletten som växt i popularitet under det senaste året? Skooby-Doo toilet, Skibidi toilet     eller Skibid toilet");
svar = Console.ReadLine();
if (svar.Equals("Skibidi toilet", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Vilken fras används under stunder då det inte har gått/kommer gå så bra? Cooked, Goated eller Fidget Spinner");
svar = Console.ReadLine();
if (svar.Equals("cooked", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Vad kallas man någon med en stor bakdel? Big Boned, Stjärna eller Gyatt");
svar = Console.ReadLine();
if (svar.Equals("Gyatt", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Vilken av de följande fraser är något som den dansande chicken nuggeten säger? gegagedigedagedago, gagegogedagedao eller gegedagagoigeo");
svar = Console.ReadLine();
if (svar.Equals("gegagedigedagedago", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
}

Console.WriteLine("Vi återgår till skibidi toilet, vem vann kriget? Skibidi toilet eller Cameramen");
svar = Console.ReadLine();
if (svar.Equals("skibidi TOILET", StringComparison.CurrentCultureIgnoreCase))
{
    p++;
    question = true;
}



if (question == true & p > 3)
{
Console.WriteLine("Bra jobbat! Du fick mer än 50% korrekt eller mer.");
Console.ReadLine();
}
else if(question == true & p < 3)
{
Console.WriteLine("Ja du, det gick inte så bra. Mindre än 50% rätt, tillbaka till mobilen nu.");
Console.ReadLine();
}
else if(question == true & p == 0)
{
Console.WriteLine("Sämst!");
Console.ReadLine();
}
else
{
Console.WriteLine("Okej, 50% rätt. Varken bra eller dåligt, kämpa på så är du nästan där!");
Console.ReadLine();
}
