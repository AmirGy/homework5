// Напишите программу, которая на вход получает размерность массива.
// Далее заполняет его случайными уникальными числами и выводит на экран.
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 

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

int[] MaxToMin(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[i]<array[j])
            {
                int tmp = array[j];
                array[j]= array[i];
                array[i]=tmp;
            }
        }
    }
    return array;
}

void RandomArray(int[] array)
{
    Random rand = new Random();
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int j = rand.Next(i + 1);
        int tmp = array[j];
        array[j] = array[i];
        array[i] = tmp;
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreateArray(size);
Console.WriteLine("Первоначальный массива:");
PrintArray(array1);
int[] array2 = MaxToMin(array1);
Console.WriteLine("Массив от большего к меньшему: ");
PrintArray(array2);
Console.WriteLine("Перемешанный массив: ");
RandomArray(array2);
