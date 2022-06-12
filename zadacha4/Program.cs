// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру дня недели (от 1 до 7)");
int daynum = Convert.ToInt32(Console.ReadLine());
if (daynum > 0 && daynum <=7)
{
    if (daynum == 6 || daynum == 7) Console.WriteLine($"{daynum} день недели выходной");
    else Console.WriteLine($"{daynum} день недели не выходной");
}
else Console.WriteLine("Неверный ввод! Введите день недели от 1 до 7");