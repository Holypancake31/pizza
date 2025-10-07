// import drawpizza;
// import EsenUtils as u;
// import turtle;


// See https://aka.ms/new-console-template for more information

// print = Console.WriteLine
// input = Console.ReadLine
// str =   ///     var str =
// true /// true
// false /// false
// for /// foreach
// += 
// and = &&
// def sprositDaNet( vopros ):    =    string sprositDaNet(string vopros)
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// строки всегда в двойных кавычках, а не в одинарных
// elif = else if
// len(names) = names.Length
// range(count) = Enumerable.Range(0,count)
// int(distanseStroka) = int.Parse(distanseStroka)


/*
 var str = 5
 var str = "5"
 str = 5

while true:
    print("privet")
    print("privet2")
print("privet3")

 */

using Pizza;

main([]);

static void main(string[] args)
{
    string[] doppizzas = [" Пицца барбекью", "четыре сезона", "Деревенская", " Фирменная", " Маргарита"];
    Console.WriteLine("Скоро в продаже! ");
    var numberPizzas = 1;

    foreach (var x in doppizzas)
    {
        Console.WriteLine(numberPizzas + "." + x);
        numberPizzas += 1;
    }

    if (EsenUtils.sprositDaNet("вы хотите сделать заказ?") == "нет")
    {
        return;
    }


    string[] namesA = ["Есения", "Рома", "Катенька", "Максик", "Тая", "Дедушка"];
    string[] parolsA = ["2013202", "505658", "1986", "фываолдж", "2011", "2027"];
    string[] skidkasA = ["40%", "35", "99", "100", "45", "15"];
    var names = namesA.ToList();
    var parols = parolsA.ToList();
    var skidkas = skidkasA.ToList();


    Console.WriteLine(":) :) :) :)");
    Console.WriteLine(":) :) :)");
    Console.WriteLine(":) :)");
    Console.WriteLine(":)");
    Console.WriteLine("Привет! 🖐 Введите логин и пароль.");


    Console.WriteLine("Ваш логин:");
    string login = Console.ReadLine();
    var login_found = false;
    var found_number = -1;
    int count = names.Count;
    var test = 1;
    string name = null;
    foreach (var number in Enumerable.Range(0, count))
    {
        test += 1;
        name = names[number];
        if (login == name)
        {
            login_found = true;
            found_number = number;
            Console.WriteLine("Добро пожаловать", name);
            break;
        }

        string needreg_ = "нет";
        if (login_found == false)
        {
            needreg_ = EsenUtils.sprositDaNet("Ваш логин не найден. Хотите зарегистрироватся как?" + login);
            if (needreg_ == "нет")
                continue;
        }
        else if (needreg_ == "да")
        {
            while (true)
            {
                Console.WriteLine("Какой будет ваш пароль?: ");
                string new_parol = Console.ReadLine();


                Console.WriteLine("Повторите пароль: ");
                string restart_parol = Console.ReadLine();
                if (restart_parol != new_parol)
                {
                    Console.WriteLine("Неверный повтор пароля. Введите пожалуйста заново.");
                }
                else
                {
                    names.Add(login);
                    parols.Add(new_parol);
                    skidkas.Add("0");
                    Console.WriteLine("Регистрация прошла успешно! Спасибо!!!");
                    break;
                }
            }
        }

        else
        {
            break;
        }
    }

// проверка пароля
    var right_parol = parols[found_number];
    EsenUtils.chekParol(name, right_parol);


    string skidki = skidkas[found_number];


    var pizza_1 = new Dictionary<string, object>();
    pizza_1["Название"] = "Пепперони";
    pizza_1["На складе"] = 10;
    pizza_1["Состав"] = "Состав пепперони: томатная паста, сыр пармезан, колбаса пеперони, тесто дрожжевое";
    pizza_1["Цена"] = 999;

    var pizza_2 = new Dictionary<string, object>();
    pizza_2["Название"] = "Сырная";
    pizza_2["На складе"] = 20;
    pizza_2["Состав"] = "Состав сырной пиццы: томатная паста, сыр моцарелла, тесто дрожжевое";
    pizza_2["Цена"] = 474;

    var pizza_3 = new Dictionary<string, object>();
    pizza_3["Название"] = "Капричиоза";
    pizza_3["На складе"] = 15;
    pizza_3["Состав"] =
        "Состав пиццы капричиозы: томатная паста, сыр пармезан, помидоры черри, грибы шампиньоны, тесто дрожжевое";
    pizza_3["Цена"] = 888;

    var pizza_4 = new Dictionary<string, object>();
    pizza_4["Название"] = "Ветчина и грибы";
    pizza_4["Состав"] = "Томатная паста, грибы шампиньоны, качественная ветчина, сыр пармезан, тесто дрожжевое";
    pizza_4["Цена"] = 1199;

    var pizza_5 = new Dictionary<string, object>();
    pizza_5["Название"] = "Оливкая";
    pizza_5["На складе"] = 25;
    pizza_5["Состав"] =
        "Состав оливковой пиццы: томатная паста, сыр пармезан, консервированные оливки, тесто дрожжевое";
    pizza_5["Цена"] = 899;


    string[] sauces = ["Брусничный соус", "Сырный соус", "Чесночный соус", "Томатный соус", "Острый соус (из перца чили)"];
    int[] price_sauces = [30, 30, 30, 30, 50];


    string[] coctails = ["Молочный коктейль", "Шоколадный коктейль", "Клубничный коктель"];
    int[] price_coctails = [299, 399, 299];

    string[] gazirovki = ["Кока-кола", "Фанта", "Пепси", "Оригинальная кока-кола"];
    int[] price_gazirovki = [69, 89, 99, 399];

    string[] soki = ["Яблочный сок", "Вишневый сок", "Апельсиновый сок"];
    int[] price_soki = [70, 99, 399];


    Dictionary<string, object> [] pizzas = [pizza_1, pizza_2, pizza_3, pizza_4, pizza_5];
    int[] pizzas_nasklade = [10, 20, 15, 10, 25];
    string[] pizzas_description =
    [
        "Состав пепперони: томатная паста, сыр пармезан, колбаса пеперони",
        "Состав сырной пиццы: томатная паста, сыр моцарелла.",
        "Состав пиццы капричиозы: томатная паста,сыр пармезан,помидоры черри,грибы шампиньоны.",
        "Томатная паста, грибы шампиньоны, качественная ветчина, сыр пармезан",
        "Состав оливковой пиццы: томатная паста,сыр пармезан,консервированные оливки. "
    ];
    int[] price_pizzas = [999, 474, 888, 1199, 899];
    var order_number = 1;


    while (true) 
    {
    Console.WriteLine(
        "Важно!: Дальше 50 км пиццу не доставляем!1 км доставки больше 3 км стоит 100 рублей. 1 км доставки до трех км стоит 70 рублей.");


    var pizza_number = EsenUtils.PrintSprositSpisok("Укажите номер пиццы:", pizzas , price_pizzas);
    Console.WriteLine(pizzas[pizza_number - 1]);
    var pizza_name = pizzas[pizza_number - 1];
    var pizza_description = pizzas_description[pizza_number - 1];
    Console.WriteLine(pizza_description);

    Console.WriteLine("Сколько вам нужно этих пицц? ");
    var countStroka = Console.ReadLine();
    bool innumber = int.TryParse(countStroka, out int num);
    while (innumber || num < 0)
    {
        Console.WriteLine("Введие пожалуйста число от одного до десяти");
        Console.WriteLine("Сколько вам нужно этих пицц? ");
        countStroka = Console.ReadLine();
    }


    var pizzas_count = int.Parse(countStroka);
    if (pizzas_count == 0)
    {
        continue;
    }

    var znazenie = pizzas_nasklade[pizza_number];
    if (pizzas_count > znazenie) 
    {
        Console.WriteLine("Вы превысили доступное кол-во." + pizza_name + "Всего доступно" + pizzas_nasklade);
        continue;
    }


    Console.WriteLine();
    string[] sizes = ["Маленькая", "Средняя", "Большая"];
    EsenUtils.printSpisok("У нас есть несколько размеров пиццы", sizes);
    int pizza_size = EsenUtils.PrintSprositSpisok("Выберите размер пиццы: ", ['1', '2', '3']);}

    Console.WriteLine("Выберете тесто: Пышное-1.Тонкое-2");
    var pizza_base = Console.ReadLine();
    while (pizza_base != "1" && pizza_base != "2") ;
    Console.WriteLine("Мы вас не понимаем.Введите заново. ");
    pizza_base = EsenUtils.input("Выберете тесто: Пышное-1.Тонкое-2  ");


    var sauce_number = 0;
    string sauce_name = "";
    var sauce_cost = 0;
    var pizza_soys = EsenUtils.sprositDaNet("Вам нужен соус?");
    if (pizza_soys == "да") 
    {
        sauce_number = EsenUtils.PrintSprositSpisok("Выберите номер соуса:",  sauces, price_sauces);
    }

// -1 чтобы все красиво записалось. Ячейки начинаются с 0. Чтоб в конечном итоге не было нуля пишется - 1.

    sauce_cost = price_sauces[sauce_number - 1];
    sauce_name = sauces[sauce_number - 1];

    var sok_number = 0;
    var zazirovka_number = 0;
    var koktel_number = 0;

    var pizzas_napitki = EsenUtils.sprositDaNet("Вам нужны напитки? ");
    if (pizzas_napitki == "да") ;
    {
        pizzas_napitki =
            EsenUtils.PrintSprositSpisok("У нас есть соки,газировки и коктели. Соки-1. Газировки-2. Коктели-3.", ['1', '2', '3']);
    }
    if (pizzas_napitki == "1") ;
    {
        sok_number = EsenUtils.PrintSprositSpisok("Выберите номер сока:", soki, price_soki);
    }


    if (pizzas_napitki == "2") ;
    {
        zazirovka_number = EsenUtils.PrintSprositSpisok("Выберите номер газировки:", gazirovki, price_gazirovki);
    }

    if (pizzas_napitki == "3")
    {
        koktel_number = EsenUtils.PrintSprositSpisok("Выберите номер коктейля:", coctails, price_coctails);
        var pizza_cost = 0;
    }

    var distanse = 0;
    
    var pizza_price = 0;
    var pizzacost = 0;
    
    var need_dostavka = EsenUtils.sprositDaNet("Нужна ли доставка?: ");
    if (need_dostavka == "да") ;
    {
        Console.WriteLine("Сколько до вас ехать?");
        var distanseStroka = Console.ReadLine();
        bool olnumber = int.TryParse(distanseStroka, out distanse);

        
        
        while (olnumber)
        {
            
            Console.WriteLine("Введие пожалуйста именно число");
            Console.WriteLine("Сколько до вас ехать?");
            distanseStroka = Console.ReadLine();
            distanse = int.Parse(distanseStroka);
            pizza_price = price_pizzas[pizza_number - 1];
            pizzacost = pizzas_count * pizza_price;


        }

    }

// Здесь вычисляется цена с учетом размера пиццы.
    if (pizza_size == "1") ;
    {
        pizzacost = pizzacost * 1;
    }
    else if (pizza_size == "2") ;
    {
            pizzacost = pizzacost * 1.3;
    }

    else if (pizza_size == "3") ;
    {
            pizzacost = pizzacost * 1.6;
    }
    if distanse == 0;
// Здесь вычисляется цена с учетом скидки.
        pizzacost = pizzacost * 0.85;

    var dostavka_cost = 0;
    if (distanse <= 3);
    {
        dostavka_cost = distanse * 70;
    }
    else if (distanse <= 50);
    {
        dostavka_cost = distanse * 100;
    }
    else
    {
        Console.WriteLine("Дальше 50 км пиццу не доставляем!");
        Console.WriteLine("Сколько до вас ехать?");
        distanse = int.Parse(Console.ReadLine());

        var total = pizza_cost + dostavka_cost + sauce_cost * skidki;
    }


    if (koktel_number > 0);
    {
        var koktel_cost = price_coctails[koktel_number - 1];
        var total = total + koktel_cost;
        var koktel_name = coctails[koktel_number - 1];
        Console.WriteLine("Вы выбрали этот коктейль: " + koktel_name + " Его цена: " + str(koktel_cost));
    }


    if (zazirovka_number > 0);
    {
        var zazirovka_cost = price_gazirovki[zazirovka_number - 1];
        var total = total + zazirovka_cost;
        var zazirovka_name = gazirovki[zazirovka_number - 1];
        Console.WriteLine("Вы выбрали эту газировку: " + zazirovka_name + " Еe цена: " + str(zazirovka_cost));
    }
    if (sok_number > 0);
    {
        var sok_cost = price_soki[sok_number - 1];
        var total = total + sok_cost;
        var sok_name = soki[sok_number - 1];
        Console.WriteLine("Вы выбрали этот сок: " + sok_name + " Его цена: " + str(sok_cost));
    }

    if (distanse == 0):
    {
        Console.WriteLine("Вам скидка!!! Радуйтесь! 15%!");
    }


    if (pizza_soys == "да")
    {
        Console.WriteLine("Вы выбрали этот соус: " + sauce_name + " Его цена: " + str(sauce_cost));
        Console.WriteLine("Вы выбрали эту пиццу: " + pizza_name + " Ее количество:" + str(pizzas_count) +
                          " Цена каждой пиццы:" + str(pizza_price));
        Console.WriteLine("С вас", total, "рублей, номер вашего заказа:", order_number);
        drawpizza.drawZakaz("peperone", int.Parse(pizza_size) * 20, pizzas_count, sauce_name);
        var new_pizza_nasklade = pizza_nasklade - pizzas_count;
        pizzas_nasklade[pizza_number - 1] = new_pizza_nasklade;

        var next_order = EsenUtils.sprositDaNet("Хотите сделать новый заказ?");


        if (next_order == "нет");
        {
            Console.WriteLine("До свидания.");
            exit();
            else
            {
                order_number = order_number + 1;

                Console.WriteLine("До свидания");
            }
        }
    }
}
