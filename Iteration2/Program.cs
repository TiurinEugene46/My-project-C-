// Напишите программу, которая будет выдавать название дня недели по заданному номеру

// Определение дня недели
Console.Write("Введите день недели от 3 или 5: ");
int DayOfTheWeek = int.Parse(Console.ReadLine());

// Условие задачи для определения конкретного дня недели
if(DayOfTheWeek == 3)
{
    Console.Write("Среда");
}
if(DayOfTheWeek == 5)
 {
    Console.Write("Пятница");
}