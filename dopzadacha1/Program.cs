// Написать программу, которая определяет, является ли треугольник со сторонами a, b ,c равнобедренным;
Console.WriteLine("Введите длину стороны 'a' в треугольнике");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны 'b' в треугольнике");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны 'c' в треугольнике");
int c = Convert.ToInt32(Console.ReadLine());
if (a == b && a == c) Console.WriteLine("Треугольник является равнобедренным");
else Console.WriteLine("Треугольник не является равнобедренным");