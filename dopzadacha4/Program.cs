Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
int indmax = 0;
int indmin = 0;
if (number > 9)
{
    while (number.Length > index)
    {
        if (number.ToString()[index] > indmax)
        {
            indmax = number.ToString()[index];
        }
        else if (number.ToString()[index] < indmin)
        {
            indmin = number.ToString()[index];
        }
        index++;     
    }
    if (indmax == indmin) Console.WriteLine("Число состоит из одинаковых чисел");
    if (indmax > indmin) Console.WriteLine("Максимальное цифра числа находтся правее, минимальная - левее");
    else Console.WriteLine("Максимальное цифра числа находтся левее, минимальная - правее");
}
else Console.WriteLine("Введите число, состоящее из нескольких цифр");
