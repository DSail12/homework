// Задача 6
// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно без остатка).
// 4 -> да;
// - 3 -> нет;
// 7 -> нет.

Console.WriteLine ("Пожалуйста, введите число");
string? numberString = Console.ReadLine();



var number = int.Parse(numberString!);




if (number%2 == 0)
{
    Console.WriteLine("Число " + number + " - четное");
}

else
{

    Console.WriteLine("Число " + number + " - нечетное");
}
