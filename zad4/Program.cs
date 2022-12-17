// Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 11);
    return array;
}

void PrintArray(double[] nums)
{
    foreach (int item in nums)
        Console.Write($"{item} ");
    Console.WriteLine();
}

void Maximum(double[] array, int size)
{
    int max = 0;
    int IndMax = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = (int)array[i];
            IndMax = i;
        }
    }
    Console.WriteLine($"Максимальное число = {max}");
    Console.WriteLine($"Индекс максимального числа = {IndMax}");
}

void Minimum(double[] array, int size)
{
    int min = 100;
    int IndMin = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min)
        {
            min = (int)array[i];
            IndMin = i;
        }
    }
    Console.WriteLine($"Минимальное число = {min}");
    Console.WriteLine($"Индекс минимального числа = {IndMin}");
}

double Average(double[] collection, int size)
{
    double sum = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        sum += collection[i];
    }

    double avr = sum / size; // collection.Average();
    Console.WriteLine($"Среднее число = {avr}");
    return avr;
}

void Mediana(double[] array)
{
    int length = array.Length - 1;
    if (length % 2 != 0)
    {
        int mid1 = length / 2;
        int mid2 = length / 2 + 1;
        double mid = (array[mid1] + array[mid2]) / 2;
        Console.WriteLine($"Медиана массива = {mid}");
    }
    else
    {
        double mid = length / 2 + 0.5;
        Console.WriteLine($"Медиана массива = {array[(int)mid]}");
    }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
PrintArray(array);
Maximum(array, size);
Minimum(array, size);
Average(array, size);
Mediana(array);

