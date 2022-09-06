// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Определение входного числа
Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());

// Получение квадрата входного числа
int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");

// Получение квадрата числа матемотической функцией
int result_2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {result_2}");