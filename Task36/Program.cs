/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//Функция заполнения массива случайными числами
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,100); //-99,99
    }
}

//Функция посчета суммы элементов, стоящих на нечетных позициях
int CountElement(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];
    return sum;
}

Console.Clear();
Console.Write("Введите желаемое колличество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

FillArray(array);
Console.WriteLine($"Массив заполненный случайными числами: [{string.Join(", ", array)}]");

int sum = CountElement(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {sum}");