// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму четных элементов, стоящих на нечётных позициях 
// (позиция - индекс элемента в массиве).

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

int[] array = new int[length];
int sum = 0;
Console.Write("array[i]: ");
for(int i = 0; i < length; i++)
{
    array[i] = random_number(min, max);
    Console.Write($"{array[i]} ");
    if(i % 2 == 1)
        if(array[i] % 2 == 0)   sum += array[i];
}

Console.WriteLine("\n" + "Сумма четных элементов, стоящих на нечётных позициях равна: " + sum);
