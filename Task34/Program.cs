/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//Функция заполнения массива
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); //[100, 999]
    }
}

//Функция поиска и подсчета четных чисел
int CountEvenNumber(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
            count ++;
    }  
    return count; 
}


Console.Clear();
Console.Write("Введите желаемое колличество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
FillArray(array);
Console.WriteLine($"Массив заполненный случайными 3х значными числами: [{string.Join(", ", array)}]");

int res = CountEvenNumber(array);
Console.WriteLine($"Колличество четных чисех: {res}");