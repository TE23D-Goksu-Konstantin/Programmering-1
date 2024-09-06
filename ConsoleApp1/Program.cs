string namn;
bool food;
string mat = "E";

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("Hej, vad heter du? Erik eller Karl.");
namn = Console.ReadLine();
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
    Console.WriteLine("Hej Karl! Gillar du senap eller ketchup?");
    mat = Console.ReadLine();
    if (mat.ToLower() == "senap")
    {
        mat = "senap";
    }
    else
    {
        mat = "ketchup";
    }
}


if (food == false)
{
    Console.WriteLine("Hej Erik! Gillar du hamburgare eller korv?");   
    mat = Console.ReadLine();
    if (mat.ToLower() == "hamburgare")  //kollar vad man skriver
    {
        mat = "hamburgare";
    }
    else
    {
        mat = "korv";
    }
}




Console.WriteLine($"Vad trevlig att träffas {namn}, jag gillar också att äta {mat}."); //resultatet
Console.ReadLine(); //skriver ut resultatet


//ctrl + * för snabb kommentar, shift + alt + upp och ner pil för kopiering, alt gr + 7 = {},
