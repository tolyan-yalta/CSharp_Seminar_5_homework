// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int random_number()
{
    int number = new Random().Next(100, 1000);
    return number;
}

Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];
int sum = 0;
Console.Write("array[i]: ");
for(int i = 0; i < length; i++)
{
    array[i] = random_number();
    
    Console.Write($" {array[i]}");
    if(array[i] % 2 == 0)
    sum = sum + 1;
}

Console.WriteLine("\n" + "В полученном массиве количество чётных чисел равно: " + sum);
