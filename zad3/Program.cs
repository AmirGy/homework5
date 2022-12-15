// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-10, 11);
    return array;
}

void PrintArray(int[] nums)
{
    foreach (int item in nums)
        Console.Write($"{item} ");
    Console.WriteLine();
}

void NumberDifference(int[] array)
{
    double max = 0;
    double min = 0;
    foreach (double item in array)
    {
        if (item > max) max = item;
        else if (item < min) min = item;
    }
    double difference = max - min;
    Console.Write($"Разница между max и min = {difference}");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
NumberDifference(array);