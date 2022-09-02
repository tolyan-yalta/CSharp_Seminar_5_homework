// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

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


Console.Write("array[i]: ");
array[0] = random_number(min, max);
Console.Write($"{array[0]} ");

int max_number = array[0];
int min_number = array[0];

for(int i = 1; i < length; i++)
{
    array[i] = random_number(min, max);
    Console.Write($"{array[i]} ");
    if(array[i] > max_number) max_number = array[i];
    if(array[i] < min_number) min_number = array[i];
}

Console.WriteLine("\n" + "Максимальный элемент массива: " + max_number);
Console.WriteLine("Минимальный элемент массива: " + min_number);

int result = max_number - min_number;
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + result);
