// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void StraightLineEquation(int number, double angle_coefficient, double free_member) //Метод записывает 
{                                                                                   //уравнение прямой                 
    double auxiliary = Math.Abs(free_member);                                       //под номером number
    if (angle_coefficient == 0)                                                     //по введенным
    {                                                                               //пользователем
        if (free_member == 0)                                                       //угловому коэффициенту
        Console.WriteLine($"Уравнение {number}-й прямой: y = 0.");                  //и свободному члену.
        else
        Console.WriteLine($"Уравнение {number}-й прямой: y = {free_member}.");
    }
    else if (angle_coefficient == 1)
    {
        if (free_member == 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = x.");
        else if (free_member > 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = x + {auxiliary}.");
        else if (free_member < 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = x - {auxiliary}.");
    } 
    else if (angle_coefficient == -1)
    {
        if (free_member == 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = -x.");
        else if (free_member > 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = -x + {auxiliary}.");
        else if (free_member < 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = -x - {auxiliary}.");
    }
    else
    {
        if (free_member == 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = {angle_coefficient}x.");
        else if (free_member > 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = {angle_coefficient}x + {auxiliary}.");
        else if (free_member < 0)
        Console.WriteLine($"Уравнение {number}-й прямой: y = {angle_coefficient}x - {auxiliary}."); 
    }
}

void IntersectionPoint(double angle_coefficient1, //Метод считает координаты точки пересечения прямых
                       double angle_coefficient2, //и записывает их в массив.
                       double free_member1,
                       double free_member2)
{
    if (angle_coefficient1 == angle_coefficient2)
    {
        if (free_member1 == free_member2)
        Console.WriteLine("Введенные вами прямые совпадают.");
        else
        Console.WriteLine("Введенные вами прямые не пересекаются.");
    }
    else
    {
        double[] array = new double[2];
        array[0] = Math.Round((free_member2 - free_member1)/(angle_coefficient1 - angle_coefficient2), 5);
        array[1] = Math.Round(angle_coefficient1 * array[0] + free_member1, 5);
        Console.WriteLine($"Введенные вами прямые пересекаются в точке K({String.Join(", ", array)})");
    }
}


Console.Clear();

Console.Write("Введите угловой коэффициент 1-й прямой k1 = ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите свободный член уравнения 1-й прямой b1 = ");
double b1 = int.Parse(Console.ReadLine()!);
StraightLineEquation(1, k1, b1);

Console.WriteLine(" ");

Console.Write("Введите угловой коэффициент 2-й прямой k2 = ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите свободный член уравнения 2-й прямой b2 = ");
double b2 = double.Parse(Console.ReadLine()!);
StraightLineEquation(2, k2, b2);

Console.WriteLine(" ");

IntersectionPoint(k1, k2, b1, b2);