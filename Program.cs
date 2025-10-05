// import drawpizza;
// import EsenUtils as u;
// import turtle;

using System.Runtime.InteropServices.JavaScript;

string[] namesA = ["Есения", "Рома", "Катенька", "Максик", "Тая", "Дедушка"];
string[] parolsA = ["2013202", "505658", "1986", "фываолдж", "2011", "2027"];
string[] skidkasA = ["40%", "35", "99", "100", "45", "15"];
var names = namesA.ToList();
var parols  = parolsA.ToList();
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
int count = (names.Length);
var test = 1;
foreach(var number in Enumerable.Range(0, count))
{
    test += 1;
    var name = names[number];
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
var right_parol = parols[found_number]
EsenUtils.chek_parol(name, right_parol);



skidki = skidkas[found_number];



pizza_1 = {}
pizza_1["Название"] = "Пепперони";
pizza_1["На складе"] = 10;
pizza_1["Состав"] = "Состав пепперони: томатная паста, сыр пармезан, колбаса пеперони, тесто дрожжевое";
pizza_1["Цена"] = 999;


pizza_2 = {}
pizza_2["Название"] = "Сырная";
pizza_2["На складе"] = 20;
pizza_2["Состав"] = "Состав сырной пиццы: томатная паста, сыр моцарелла, тесто дрожжевое";
pizza_2["Цена"] = 474;


pizza_3 = {}
pizza_3["Название"] = "Капричиоза";
pizza_3["На складе"] = 15;
pizza_3["Состав"] = "Состав пиццы капричиозы: томатная паста, сыр пармезан, помидоры черри, грибы шампиньоны, тесто дрожжевое";
pizza_3["Цена"] = 888;

pizza_4 = {}
pizza_4["Название"] = "Ветчина и грибы";
pizza_4["Состав"] = "Томатная паста, грибы шампиньоны, качественная ветчина, сыр пармезан, тесто дрожжевое";
pizza_4["Цена"] = 1199;

pizza_5 = {}
pizza_5["Название"] = "Оливкая";
pizza_5["На складе"] = 25;
pizza_5["Состав"] = "Состав оливковой пиццы: томатная паста, сыр пармезан, консервированные оливки, тесто дрожжевое";
pizza_5["Цена"] = 899;



string[] sauces = ["Брусничный соус", "Сырный соус", "Чесночный соус", "Томатный соус", "Острый соус (из перца чили)"];
string[] price_sauces = [30, 30, 30, 30, 50];


string[] coctails = ["Молочный коктейль", "Шоколадный коктейль", "Клубничный коктель"];
string[] price_coctails = [299, 399, 299];

string[] gazirovki = ["Кока-кола", "Фанта", "Пепси", "Оригинальная кока-кола"];
string[] price_gazirovki = [69, 89, 99, 399];

string[] soki = ["Яблочный сок", "Вишневый сок", "Апельсиновый сок"];
string[] price_soki = [70, 99, 399];


string[] pizzas = [pizza_1, pizza_2, pizza_3, pizza_4, pizza_5];
string[] pizzas_nasklade = [10, 20, 15, 10, 25];
string[] pizzas_description =
[
    "Состав пепперони: томатная паста, сыр пармезан, колбаса пеперони",
    "Состав сырной пиццы: томатная паста, сыр моцарелла.",
    "Состав пиццы капричиозы: томатная паста,сыр пармезан,помидоры черри,грибы шампиньоны.",
    "Томатная паста, грибы шампиньоны, качественная ветчина, сыр пармезан",
    "Состав оливковой пиццы: томатная паста,сыр пармезан,консервированные оливки. "
];
string[] price_pizzas = [999, 474, 888, 1199, 899];
order_number = 1;


while (true) ;

Console.WriteLine("Важно!: Дальше 50 км пиццу не доставляем!1 км доставки больше 3 км стоит 100 рублей. 1 км доставки до трех км стоит 70 рублей.");



pizza_number = u.printSprositSpisok("Укажите номер пиццы:", pizzas, price_pizzas)
Console.WriteLine(pizzas[pizza_number - 1]);
pizza_name = pizzas[pizza_number - 1];
pizza_description = pizzas_description[pizza_number - 1];
Console.WriteLine(pizza_description);

countStroka = Console.ReadLine("Сколько вам нужно этих пицц? ");
    while countStroka.isnumeric() == false or int(countStroka) < 0;
    Console.WriteLine("Введие пожалуйста число от одного до десяти");
    countStroka = Console.ReadLine("Сколько вам нужно этих пицц? ");

    pizzas_count = int.Parse(countStroka);
    if pizzas_count == 0;
    continue;
    if pizzas_count > pizza_nasklade;
    Console.WriteLine("Вы превысили доступное кол-во.", pizza_name, "Всего доступно", pizza_nasklade);
    continue;


    Console.WriteLine();
        string[] sizes = ["Маленькая", "Средняя", "Большая"];
        u.printSpisok("У нас есть несколько размеров пиццы", sizes);
        pizza_size = u.sprositSpisok("Выберите размер пиццы: ", ['1', '2', '3']);


        pizza_base = Console.ReadLine("Выберете тесто: Пышное-1.Тонкое-2");
        while pizza_base != "1" and pizza_base != "2";
        Console.WriteLine("Мы вас не понимаем.Введите заново. ");
        pizza_base = Console.ReadLine("Выберете тесто: Пышное-1.Тонкое-2  ");


    sauce_number = 0;
    sauce_name = 0;
    sauce_cost = 0;
    pizza_soys = u.sprositDaNet("Вам нужен соус?");
    if pizza_soys == "да";
    sauce_number = u.printSprositSpisok("Выберите номер соуса:", sauces, price_sauces);
        
// -1 чтобы все красиво записалось. Ячейки начинаются с 0. Чтоб в конечном итоге не было нуля пишется - 1.

    sauce_cost = price_sauces[sauce_number - 1];
    sauce_name = sauces[sauce_number - 1];

    sok_number = 0;
    zazirovka_number = 0;
    koktel_number = 0;

    pizzas_napitki = u.sprositDaNet("Вам нужны напитки? "); 
    if pizzas_napitki == "да";
    pizza_napitki =
        u.sprositSpisok("У нас есть соки,газировки и коктели. Соки-1. Газировки-2. Коктели-3.", ['1', '2', '3']); 
       
        if pizza_napitki == "1";
        sok_number = u.printSprositSpisok("Выберите номер сока:", soki, price_soki);
             

      
        if pizza_napitki == "2";
        zazirovka_number = u.printSprositSpisok("Выберите номер газировки:", gazirovki, price_gazirovki);
           

        if pizza_napitki == "3";
        koktel_number = u.printSprositSpisok("Выберите номер коктейля:", coctails, price_coctails);

        distanse = 0;
        need_dostavka = u.sprositDaNet("Нужна ли доставка?: ");
    if need_dostavka == "да";
    distanseStroka = Console.ReadLine("Сколько до вас ехать?");
        while distanseStroka.isnumeric() != true;
        Console.WriteLine("Введие пожалуйста именно число");
        distanseStroka = Console.ReadLine("Сколько до вас ехать?");
        distanse = int.Parse(distanseStroka);
        pizza_price = price_pizzas[pizza_number - 1];
        pizza_cost = pizzas_count * pizza_price;
    
// Здесь вычисляется цена с учетом размера пиццы.
    if pizza_size == "1";
        pizza_cost = pizza_cost * 1;
    else if pizza_size == "2";
        pizza_cost = pizza_cost * 1.3;
    else if pizza_size == "3";
        pizza_cost = pizza_cost * 1.6;

    if distanse == 0;
// Здесь вычисляется цена с учетом скидки.
    pizza_cost = pizza_cost * 0.85;

    dostavka_cost = 0;
    if distanse <= 3;
    dostavka_cost = distanse * 70;
    else if distanse <= 50;
    dostavka_cost = distanse * 100;
    else;
    Console.WriteLine("Дальше 50 км пиццу не доставляем!");
    distanse = int.Parse(input("Сколько до вас ехать?"));

    total = pizza_cost + dostavka_cost + sauce_cost * skidki;


    if koktel_number > 0;
    koktel_cost = price_coctails[koktel_number - 1];
        total = total + koktel_cost;
        koktel_name = coctails[koktel_number - 1];
        Console.WriteLine("Вы выбрали этот коктейль: " + koktel_name + " Его цена: " + str(koktel_cost));
    

    if zazirovka_number > 0;
    zazirovka_cost = price_gazirovki[zazirovka_number - 1];
    total = total + zazirovka_cost;
    zazirovka_name = gazirovki[zazirovka_number - 1];
        Console.WriteLine("Вы выбрали эту газировку: " + zazirovka_name + " Еe цена: " + str(zazirovka_cost));

    if sok_number > 0;
    sok_cost = price_soki[sok_number - 1];
        total = total + sok_cost;
        sok_name = soki[sok_number - 1];
        Console.WriteLine("Вы выбрали этот сок: " + sok_name + " Его цена: " + str(sok_cost));
 
    
    if distanse==0:
    Console.WriteLine("Вам скидка!!! Радуйтесь! 15%!");
    

    if pizza_soys == "да":
    Console.WriteLine("Вы выбрали этот соус: " + sauce_name + " Его цена: " + str(sauce_cost));  
    Console.WriteLine ("Вы выбрали эту пиццу: "+pizza_name+" Ее количество:"+str(pizzas_count)+" Цена каждой пиццы:"+str(pizza_price));

    Console.WriteLine("С вас", total, "рублей, номер вашего заказа:", order_number);
    drawpizza.drawZakaz("peperone", int.Parse(pizza_size) * 20, pizzas_count, sauce_name);
    new_pizza_nasklade = pizza_nasklade - pizzas_count;
    pizzas_nasklade[pizza_number - 1] = new_pizza_nasklade;

    next_order = u.sprositDaNet("Хотите сделать новый заказ?");
    if next_order == "нет";
    Console.WriteLine("До свидания.");
    exit();
    else
        order_number = order_number + 1;


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

        static void main(JSType.String[] args)
        {
            string[] doppizzas = [" Пицца барбекью", "четыре сезона", "Деревенская", " Фирменная", " Маргарита"];
            Console.WriteLine("Скоро в продаже! ");
            var number = 1;

            foreach (var x in doppizzas)
            {
                Console.WriteLine(number + "." + x);
                number += 1;
            }

            if (EsenUtils.sprositDaNet("вы хотите сделать заказ?") == "нет")
            {
                return;
            }

            while (true)
            { 
                Console.WriteLine("Введите название пиццы: ");
                string str = Console.ReadLine();
                Console.WriteLine("Введите количество пиццы: ");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("вы выбрали пиццу " + str + " и выбрали количество = " + count);

                Console.WriteLine("Хотите сделать еще заказ? (да/нет)");
                string otvet = Console.ReadLine();
                if (otvet == "нет")
                {
                    break;
                }
            }
            Console.WriteLine("До свидания");
        }


