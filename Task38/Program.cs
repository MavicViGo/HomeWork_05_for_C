/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
void FillArray(double[] array)
{
    int end = 100, begin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
    }
}

double SumMinMax(double[] array)
{
    double sum = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
        else if (max < array[i])
            max = array[i];
    }
    sum = Math.Round(min + max, 2);
    return sum;
}

Console.Clear();
Console.Write("Введите желаемое колличество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
FillArray(array);
Console.WriteLine($"Массив случайных вещественных чисел: {string.Join("; ", array)}");

double res = SumMinMax(array);
Console.WriteLine($"Сумма минимального и максимального элемента = {res}");