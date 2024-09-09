string namn = "";
bool food;
string mat = "";

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.Red;               //text färg + bakgrundsfärg


Console.WriteLine("Hej, vad heter du? Erik eller Karl.");
while (!namn.Equals("Erik", StringComparison.CurrentCultureIgnoreCase) && !namn.Equals("Karl", StringComparison.CurrentCultureIgnoreCase)) //använda quick fix för att fixa det
{
    namn = Console.ReadLine();
}

if (namn.ToLower() == "karl")
{
    namn = "Karl";
    food = true;     //blir sant eller falskt beroende på användarens svar vilket resulterar i olika val.
}
else
{
    namn = "Erik";
    food = false;
}

if (food == true)
{
    Console.WriteLine("Hej Karl! Gillar du katt eller hund?");
    while (mat.ToLower() != "katt" && mat.ToLower() != "hund")
    {
    mat = Console.ReadLine();
    }
    if (mat.ToLower() == "katt")
    {
        mat = "katt";
    }
    else
    {
        mat = "hund";
    }
}


if (food == false)
{

    Console.WriteLine("Hej Erik! Gillar du hamburgare, korv eller sallad?");
    while (mat.ToLower() != "hamburgare" && mat.ToLower() != "korv" && mat.ToLower() != "sallad")
    {
    mat = Console.ReadLine();
    }
    if (mat.ToLower() == "hamburgare")  //kollar vad man skriver
    {
        mat = "hamburgare";
    }
    else if (mat.ToLower() == "korv")
    {
        mat = "korv";                 //tre alternativ
    }
    else
        mat = "sallad";
}


Console.WriteLine($"Vad trevlig att träffas {namn}, jag gillar också att äta {mat}."); //resultatet
Console.ReadLine(); //skriver ut resultatet







//ctrl + * för snabb kommentar, shift + alt + upp och ner pil för kopiering, alt gr + 7 = {},
