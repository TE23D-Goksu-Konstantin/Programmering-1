string namn;
bool food1;
string food = "ee";    //fungerade inte utan ett "startvärde"

Console.WriteLine("Hej, vad heter du? Karl eller Kalle.");

if (Console.ReadLine() == "Karl")
{
    namn = "Karl";
    food1 = true;     //blir sant eller falskt beroende på användarens svar vilket resulterar i olika val.
}
else
 {
namn = "Kalle";
food1 = false;
}       

if (food1 == true)
{
    Console.WriteLine("Gillar Karl senap eller hundkött");
    if (Console.ReadLine() == "senap")
    {
        food = "senap";
    }
    else
    {
        food = "hundkött";
    }
}


if (food1 == false)
{
    Console.WriteLine("Gillar Kalle ketchup eller kattkött");   
    if (Console.ReadLine() == "ketchup")  //kollar vad man skriver, "ketchup" = ketchup och allt annat blir kattkött
    {
        food = "ketchup";
    }
    else
    {
        food = "kattkött";
    }
}




Console.WriteLine($"{namn} gillar att äta {food}"); //skriver ut resultatet
Console.ReadLine();


//ctrl + * för snabb kommentar, shift + alt + upp och ner pil för kopiering, alt gr + 7 = {},