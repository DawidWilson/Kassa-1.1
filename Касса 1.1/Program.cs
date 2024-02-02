
using System;
using System.Text.Unicode;
// Объевляем константы
const string ORGANIZATIONNAME = "ООО\"Усатый фермер\"";
const string INN = "385762";
DateTime currenDate = DateTime.Now;

// Просим ввести ко-во денег
Console.WriteLine("Введите кол-во денег:");
decimal money = decimal.Parse(Console.ReadLine());
Console.WriteLine("\n\n");

// Пишем прайс
const decimal butter = 150;
const decimal bread = 50;
const decimal tea = 80;
const decimal Gloves = 230;
const decimal Hats = 300;
const decimal Shirts = 550;

//                      Выводим прайс
Console.WriteLine($"{"Название",28}{"Цена",15}\n\t\t{"***********************",27}\n{"Хлеб",24}{butter,18}\n{"Масло",25}{bread,17}\n{"Чай",23}{tea,19}\n{"Перчатки",28}{Gloves,14}\n{"Шапки",25}{Hats,17}\n{"Рубашки",27}{Shirts,15}\n\n");

//              Просим ввести количество необходимого товара
Console.WriteLine("Введите количество масла");
int quontiyButter = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество хлеба");
int quontiyBread = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество чая");
int quontiyTea = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество перчаток");
int quontiyGloves = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество шапок");
int quontiyHats = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество рубашек");
int quontiyShirts = int.Parse(Console.ReadLine());
Console.WriteLine("\n\n");

//              Считаем сумму нужного кол-во
decimal totalButter = butter * quontiyButter;
decimal totalBread = bread * quontiyBread;
decimal totalTea = tea * quontiyTea;
decimal totalGloves = Gloves * quontiyGloves;
decimal totalHats = Hats * quontiyHats;
decimal totalShirts = Shirts * quontiyShirts;
decimal totalProductprice = totalButter + totalBread + totalTea;


if (money > totalProductprice)
{
    Console.WriteLine($"{"На вашем балансе останется",60} {money - totalProductprice}\n\n\n");



    //                        Шапка чека
    Console.WriteLine($"{ORGANIZATIONNAME,58}\n{INN,26} {currenDate,45}");
    Console.WriteLine($"{"Название",28}{"Цена",18}{"Кол-во",13}{"Сумма",13}\n\t\t{"****************************************************",56}");

    //                       Внутриности чека
    //              Расчитываем НДС для каждого продукта

    //                          Хлеб
    Console.WriteLine($"{"ХЛЕБ",24}{bread,22}{quontiyBread,10}{totalBread,15}");
    decimal totalBreadNds = (totalBread / 200) * 20;
    Console.Write($"{"НДС с рачитаной",35}{totalBreadNds,36:F1}\n{"ставкой 20%",31}\n\n");

    //                          Масло
    Console.WriteLine($"{"МАСЛО",25}{butter,21}{quontiyButter,10}{totalButter,15}");
    decimal totalButterNds = (totalButter / 150) * 15;
    Console.Write($"{"НДС с рачитаной",35}{totalButterNds,36:F1}\n{"ставкой 15%",31}\n\n");

    //                          Чай
    Console.WriteLine($"{"ЧАЙ",23}{tea,23}{quontiyTea,10}{totalTea,15}");
    decimal totalTeaNds = (totalTea / 100) * 10;
    Console.Write($"{"НДС с рачитаной",35}{totalTeaNds,36:F1}\n{"ставкой 10%",31}\n\n");
    //                          Перчатки
    Console.WriteLine($"{"ПЕРЧАТКИ",28}{Gloves,18}{quontiyGloves,10}{totalGloves,15}");
    decimal totalGlovesNds = (totalGloves / 200) * 20;
    Console.Write($"{"НДС с рачитаной",35}{totalGlovesNds,36:F1}\n{"ставкой 20%",31}\n\n");
    //                          Шапки
    Console.WriteLine($"{"ШАПКИ",25}{Hats,21}{quontiyHats,10}{totalHats,15}");
    decimal totalHatsNds = (totalHats / 200) * 20;
    Console.Write($"{"НДС с рачитаной",35}{totalHatsNds,36:F1}\n{"ставкой 20%",31}\n\n");
    //                          Рубашки
    Console.WriteLine($"{"РУБАШКИ",27}{Shirts,19}{quontiyShirts,10}{totalShirts,15}");
    decimal totalShirtsNds = (totalShirts / 200) * 20;
    Console.Write($"{"НДС с рачитаной",35}{totalGlovesNds,36:F1}\n{"ставкой 20%",31}\n\n");

    //                   Итого всего чека
    Console.WriteLine($"{"****************************************************",72}");

    decimal totalPriceAll = totalButter + totalBread + totalTea+ totalGloves+totalHats+totalShirts;
    Console.WriteLine($"{"ИТОГО",25}{totalPriceAll,46}");

    decimal totalNdsPrice = totalButterNds + totalBreadNds + totalTeaNds+totalGlovesNds+totalHatsNds+totalShirtsNds;
    Console.WriteLine($"{"НДС общее чека",34}{totalNdsPrice,37:F1}\n");


    Console.WriteLine($"{"****************************************************",72}\n{"ВИД НАЛОГООБЛОЖЕНИЯ:",40}{"Осн",31}\n{"РЕГ.НОМЕР ККТ:",34}{"0000143873023483",37}\n{"ЗАВОД №:",28}\n{"ФН №:",25}{"8710000100265168",46}\n{"ФД №:",25}{"6026",46}\n{"ФПД:",24}{"3322278314",47}");
}
else
{
    Console.WriteLine($"На вашем счету не достаточно средств");
}
  