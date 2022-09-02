// Задайте массив натуральных чисел. 
// Найти максимальный элемент, потом минимальный и после сложить все числа, 
// которые строго лежат между минимальным и максимальным элементами. 
// Сами максимальный и минимальный элементы в суммировании не участвуют.

int random_number(int min, int max)
{
    int number = new Random().Next(min, max);
    return number;
}

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество элементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());

if(length < 0)
{
    length = 0;
    //Console.WriteLine("Массив не может иметь отрицательный размер размер.");
    //Environment.Exit(0);
}

switch(length)
{
    case 0:
    Console.WriteLine("Массив не может иметь нулевой или отрицательный размер размер.");
    break;
    case 1:
    case 2:
    Console.WriteLine("В таком массиве нет элементов между минимальным и максимальным.");
    break;
    default:

    int[] array = new int[length];

    Console.Write("array[i]: ");
    array[0] = random_number(min, max);
    Console.Write($"{array[0]} ");

    int max_number = array[0];
    int min_number = array[0];
    int index_max = 0;
    int index_min =0;

    for(int i = 1; i < length; i++)
    {
        array[i] = random_number(min, max);
        Console.Write($"{array[i]} ");
        if(array[i] > max_number)
        {
            max_number = array[i];
            index_max = i;
        } 
        if(array[i] < min_number)
        {
            min_number = array[i];
            index_min = i;
        } 
    }

    int sum(int index_min, int index_max)
    {
        int sum = 0;
        int i = index_min + 1;
        for(; i < index_max; i++) sum += array[i];
        return sum;
    }

    Console.WriteLine("\n" + "Индекс максимального элемента массива: " + index_max);
    Console.WriteLine("Индекс минимального элемента массива: " + index_min);

    int result;
    if(index_min > index_max)
    {
        int temp = index_max;
        index_max = index_min;
        index_min =temp;
    }
    result = sum(index_min, index_max);

    Console.WriteLine("Сумма всех чисел между минимальным и максимальным элементами равна: " + result);

    break;
}
