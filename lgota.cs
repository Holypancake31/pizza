static void calculatelgota(string[] prms)
{
decimal result = 0;
decimal price = 100;

Console.WriteLine("Сколько вам лет?");
string lolo = Console.ReadLine();
int age = int.Parse(lolo);

if (age >= 7 && age <= 18)
{ 
    result = price * 0.5m;
}
else if (age >= 18)

{
    
    result = price;
}
else if (age <= 7)
{
    result = 0;
}


    Console.WriteLine("Вы льготник?");
    string lala = Console.ReadLine();
    bool islgot = bool.Parse(lala);
    if (islgot && age <= 18)
    {
        result = 0;
    }

    Console.WriteLine(result);
}
