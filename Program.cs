// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Enter the length of the array --> ");
int Leng = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[Leng];

void NumsEvenValues(int[] Array)
{
    int EvenValues = 0;
    for (int i = 0; i < Leng; i++)
    {
        Array[i] = new Random().Next(100, 1000);
        if (Array[i] % 2 != 0 )
        {
            EvenValues++;
        }
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Numb of even values --> {EvenValues}");
}
NumsEvenValues(Array);