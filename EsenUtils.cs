namespace Pizza;

public static class EsenUtils
{
    /// <summary>
    /// спрашивает у пользователя да нет
    /// </summary>
    public static string sprositDaNet(string vopros)
    {
        Console.WriteLine(vopros);
        string text = Console.ReadLine();
        while (text != "да" && text != "нет")
        {
            Console.WriteLine("Мы вас не понимаем. Введите заново.");
            text = Console.ReadLine();
        }
        return text;
    }
    //функция проверка пароля
    public static void chekParol(string name,string right_parol)
    {
        while (true)
        {
            Console.WriteLine("Ваш пароль");
            var parol = Console.ReadLine();
            if (parol != right_parol)
            {
                Console.WriteLine("Неверный пароль");
                continue;
            }
            else
            {
                Console.WriteLine("Пароль правильный. Добро пожаловать " + name);
                break;
            }
        }
    }   
    
// Эта функция красиво оформляет строки(названия товаров с ценой)

    public static void printSpisokPrices(string spisok, string[] price_spisok)
    {
        var infa = "";
        int x = 0;
        foreach (var item in spisok)
        {
            infa = infa + (x + 1) + ". " + item + " - " + (price_spisok[x]) + " руб.\n";
            x = x + 1;
            Console.WriteLine(infa);
        }
    }
    
    
    
// Тут красиво оформляется только название(товаров)
    public static void printSpisok(string title, string spisok)
    {
        Console.WriteLine(title);
        var infa = "";
        var x = 0;
        foreach (var item in spisok)
        {
            infa = infa + (x + 1) + ". " + item + "\n";
            x = x + 1;
        }

        Console.WriteLine(infa);

    }

// Эта функция красиво оформляет строки. И не дает написать меньше одного а также не дает написать больше чем длина списка.
    public static int printSpisok(string vopros, string spisok, string[] price_spisok)
    {
        Console.WriteLine(vopros);
        printSpisokPrices(spisok, price_spisok);
        var max_number = spisok.Length;
        Console.WriteLine(vopros);
        var answer = Console.ReadLine();
        bool isnumber = int.TryParse(answer, out int num);
        while(isnumber || num > max_number || num < 1)
        {
            Console.WriteLine("Мы вас не понимаем. Введите заново. Число от 1 до", max_number);
            Console.WriteLine(vopros);
            answer = Console.ReadLine();
            isnumber = int.TryParse(answer, out num);
        }
        return int.Parse(answer);
    }

    
    
    
}


