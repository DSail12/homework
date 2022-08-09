// Задача 4
// Напишиет программу, которая принимает на входе три числа и выдает максимальное из этих чисел.


Console.WriteLine ("Пожалуйста, введите три числа");
string? numberString1 = Console.ReadLine();
string? numberString2 = Console.ReadLine();
string? numberString3 = Console.ReadLine();

var number1 = int.Parse(numberString1!);
var number2 = int.Parse(numberString2!);
var number3 = int.Parse(numberString3!);



if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("Максимальным числом будет " + number1);
}

else
{
    if (number2 > number3)
{
    Console.WriteLine("Максимальным числом будет " + number2);
}
else
{
  Console.WriteLine("Максимальным числом будет " + number3);
}
}