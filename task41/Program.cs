// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Задача 41. Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввел пользователь.

int[] GetNumbersRow(int amount)
{
    int[] result_array = new int[amount];
    for (int i = 0; i <= amount - 1; i++)
    {
        Console.Write($"Введите {i}-й элемента массива: ");
        result_array[i] = int.Parse(Console.ReadLine()!);
    }
    return result_array;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}

Console.Clear();

Console.Write("Введите длину массива: ");
int number = int.Parse(Console.ReadLine()!);

int[] working_array = GetNumbersRow(number);
Console.WriteLine($"Полученный массив: [{String.Join(", ", working_array)}]");

int positive_numbers = CountPositiveNumbers(working_array);
Console.Write($"Количество элементов, больших нуля, равно {positive_numbers}.");
