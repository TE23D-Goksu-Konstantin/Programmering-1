string choice;
int choiceout;
int x = 4;
int i;
int y;

Console.WriteLine("Välkommen, ditt jobb är att anställa de rekryter som finns med.");
Thread.Sleep(2000);
Console.WriteLine("Tryck på enter för att gå vidare");
Console.ReadLine();
Console.Clear();


List<string> names = ["Konstantin", "Abraham", "Kalle", "Ostmannen"];
List<string> names2 = [];


while(x > 0)
{
    Console.WriteLine("Ej Anställda:");
for (i=0; i < names.Count; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"{i}. {names[i]}");
    Console.WriteLine("");
}

Console.WriteLine("Anställda:");
for (y=0; y < names2.Count; y++)
{
    Console.WriteLine("");
    Console.WriteLine($"{y}. {names2[y]}");
    Console.WriteLine("");
}

choice = Console.ReadLine();
int.TryParse(choice, out choiceout);


if (choiceout <= 3)
{
    names2.Add(names[choiceout]);
    names.RemoveAt(choiceout);
    x--;
    Console.Clear();  
    }
    else
    {
        Console.WriteLine("Det gick ej, vänligen skriv om ditt val.");
        Console.WriteLine("Tryck på enter för att gå vidare.");
        Console.ReadLine();
    } 
}



if (x == 0)
{
    Console.WriteLine("Du har anställt alla existerande rekryter, välkommen åter!");
    Thread.Sleep(3000);
    Environment.Exit(0);
}
