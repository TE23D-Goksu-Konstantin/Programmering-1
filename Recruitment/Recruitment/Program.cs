using System.Xml.Serialization;
string choice;
int choiceout;
int x = 5;

Console.WriteLine("Välkommen, ditt jobb är att anställa de rekryter som finns med.");
Thread.Sleep(2000);
Console.WriteLine("Tryck på enter för att gå vidare");
Console.ReadLine();
Console.Clear();


List<string> names = ["1. Konstantin", "2. Abraham", "3. Kalle", "4. Ostmannen", "5. Jazz"];
List<string> names2 = [];


while(x > 0)
{
    Console.WriteLine("Ej Anställda");
for (int i=0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
    Console.WriteLine("");
}

Console.WriteLine("Anställda");
for (int y=0; y < names2.Count; y++)
{
    Console.WriteLine(names2[y]);
    Console.WriteLine("");
}

choice = Console.ReadLine();
int.TryParse(choice,out choiceout);

if (choiceout == 1)
{
    names2.Add(names[0]);
    names.RemoveAt(0);
    Console.Clear();
    x--;
}
else if (choiceout == 2){
    names2.Add(names[1]);
    names.RemoveAt(1);
    Console.Clear();
    x--;
}
else if (choiceout == 3){
    names2.Add(names[2]);
    names.RemoveAt(2);
    Console.Clear();
    x--;
}
else if (choiceout == 4){
    names2.Add(names[3]);
    names.RemoveAt(3);
    Console.Clear();
    x--;
}
else if (choiceout == 5){
    names2.Add(names[4]);
    names.RemoveAt(4);
    Console.Clear();
    x--;
    }
}


if (x == 0)
{
    Console.WriteLine("Du har anställt alla existerande rekryter, välkommen åter!");
    Thread.Sleep(3000);
    Environment.Exit(0);
}
