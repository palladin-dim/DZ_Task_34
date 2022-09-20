/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0)
    count++;

Console.WriteLine($"Чётных чисел в массиве: -> {count} ");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + ", ");
    }
    Console.Write("]");
    Console.WriteLine("");
}

