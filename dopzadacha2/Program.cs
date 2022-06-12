// 
/* На вход подаются год, номер месяца и день рождения человека. 
Определить возраст человека на момент 1 июля 2022 года.
*/

Console.WriteLine("Введите день рождения");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру месяца рождения");
int months = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год рождения");
int year = Convert.ToInt32(Console.ReadLine());
if (months <=12 && day <= 31 && year < 2022 || (year == 2022 && months < 7 || (year == 2022 && months == 7 && day == 1)))
{
    if (months < 7 || (months == 7 && day == 1)) Console.WriteLine($"Возраст человека 1 июля 2022 года равен {2022 - year} лет");
    else Console.WriteLine($"Возраст человека 1 июля 2022 года равен {2021 - year} лет(год)"); 
}
else Console.WriteLine("Дата введена некорректно");
