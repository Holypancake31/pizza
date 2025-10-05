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
    //функция
    //проверка пароля
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
    
    //jkjk
    




}


