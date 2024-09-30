Console.OutputEncoding = System.Text.Encoding.UTF8;
string val_1 = "";
while (val_1 != "1" && val_1 != "2")
{
    Console.WriteLine("Tryck 1 för Xia Pang Tryck 2 för Doomfist:");
    val_1 = Console.ReadLine();
}



if (val_1 == "1")
{

    Console.WriteLine("Du spelar som Xia Pang");
}

else if (val_1 == "2")
{
    Console.WriteLine("Du spelar som Doomfist");
}


int Xia_Panghp = 100; // jolly
int Doomfisthp = 250; // evil 


string Kämpe1 = "Xia_Pang";
string kämpe2 = "Doomfist";


Random bejing = new Random();



while (Xia_Panghp > 0 && Doomfisthp > 0)
{
    Console.Clear();
    Console.WriteLine("\n ------ ===== Ny runda ===== -------");
    Console.WriteLine($"{Kämpe1}: {Xia_Panghp}  {kämpe2}:  {Doomfisthp}");


    int Xia_Pangdmg = bejing.Next(80);

    Doomfisthp -= Xia_Pangdmg;
    Doomfisthp = Math.Max(0, Doomfisthp);
    Console.WriteLine($"{Kämpe1} åstakommer {Xia_Pangdmg} dmg på {kämpe2}");


    int Doomfistdmg = bejing.Next(20);

    Xia_Panghp -= Doomfistdmg;
    Xia_Panghp = Math.Max(0, Xia_Panghp);
    Console.WriteLine($"{kämpe2} rocket punch gör {Doomfistdmg}dmg på {Kämpe1}");

    Console.WriteLine("Tryck på valfri knapp");
    Console.ReadKey();
}

Console.WriteLine("\n ----- ===== Rundan är över ===== -----");

if (Xia_Panghp == 0 && Doomfisthp == 0)
{
    Console.WriteLine("Oavgjort!");

}

else if (Xia_Panghp == 0)
{
    Console.WriteLine("Doomfist vinner!");
}

else
{
    Console.WriteLine("Xia Pang vinner!");
}

Console.WriteLine("Stäng av spelet med valfri knapp!");
Console.ReadKey();







Console.ReadLine();