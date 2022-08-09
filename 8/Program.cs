// Задача 8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// 5 -> 2, 4;
// 8 -> 2, 4, 6, 8.

Console.WriteLine("Введите пожалуйста положительное целое число от 1 до N на Ваш выбор");

string numberString = Console.ReadLine()!;

int number = int.Parse(numberString);

if (number <= 0)
{
    Console.WriteLine ("Введено отрицательное число или ноль. Попытайтесь снова");
}

else

{
    for (int i = 1; i <= number; i++)
    if (i%2 == 0)
    Console.WriteLine(i);
}