// Задача 2
// Напишите программу, которая на вход принимает два числа и выдает, какое большее, а какое меньшее.


Console.WriteLine ("Пожалуйста, введите два числа");
string? numberString1 = Console.ReadLine();
string? numberString2 = Console.ReadLine();


var number1 = int.Parse(numberString1!);
var number2 = int.Parse(numberString2!);



if (number1 == number2)
{
    Console.WriteLine("Числа равны, введите значения снова");
}

else
{
    if (number2 > number1)
{
    Console.WriteLine("Число " + number2 + " - наибольшее значение ");
    Console.WriteLine("Число " + number1 + " - наименьшее значение ");
}
else
{
    Console.WriteLine("Число " + number1 + " - наибольшее значение ");
    Console.WriteLine("Число " + number2 + " - наименьшее значение ");
}
}
