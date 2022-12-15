// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfNech(int[] array, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.Write(SumOfNech(array, size));