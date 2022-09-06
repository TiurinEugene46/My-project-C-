// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Определение входных чисел
Console.WriteLine("Введиnе числа: ");
int result = int.Parse(Console.ReadLine());
int number = int.Parse(Console.ReadLine());

// Условие получения квадрата второго входного числа
if(result == number * number)
{
    Console.WriteLine($"{result} квадрат числа {number}");
}
else
{
    Console.WriteLine($"{result} не является квадратом числа {number}");
}