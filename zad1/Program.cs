// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void PrintArray(int[] nums)
{
    foreach (int item in nums)
        Console.Write($"{item} ");
    Console.WriteLine();
}

void Chetnyy(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if(item % 2 == 0) count++;
    }
    Console.Write(count);
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Chetnyy(array);
