// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());

int startNumber = Math.Abs(number) * -1;
while(startNumber <= number) {
    Console.WriteLine(startNumber);
    startNumber = startNumber + 1;
}