// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble()*100;
    return array;
}

void PrintArray(double[] nums)
{
    foreach (double item in nums)
    {
        double round = Math.Round(item, 2);
        Console.Write($"{round}  ");
    }
    Console.WriteLine();
}

void NumberDifference(double[] array)
{
    double max = 0;
    double min = 100;
    foreach (double item in array)
    {
        if (item > max) max = item;
        else if (item < min) min = item;
    }
    double difference = max - min;
    double round = Math.Round(difference, 2);
    double roundMax = Math.Round(max, 2);
    double roundMin = Math.Round(min, 2);
    Console.Write($"Разница между max: {roundMax} и min: {roundMin} = {round}");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
PrintArray(array);
NumberDifference(array);