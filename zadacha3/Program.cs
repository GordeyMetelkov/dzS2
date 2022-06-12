// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Третья цифра {a.ToString()[2]}");
