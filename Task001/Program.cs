// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]
// Найдите сумму отрицательных и положительных элементов массива
// Например, в массиве [3,9,-8,1,0,-7,2,-3,-1,6]
//  сумма положительных чисел равна 29, сумма 
//  отрицательных равна -20

// Вариант 1

// Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]

// int[] MakeNewRandomArray(int size, int beginValue, int endValue)
// {
//     int[] array = new  int[size];
//     for (int i = 0; i < size; i++) 
//         array [i] = new Random().Next(beginValue, endValue );
//     return array;
// }
// int[] array = MakeNewRandomArray(12, -9, 9);

// Console.WriteLine(string.Join(", ", array));  

// // Найдите сумму отрицательных и положительных элементов массива
// // Например, в массиве

// int positiveSum = 0;
// int negativeSum = 0;
// for (int i = 0; i < array.Length; i++) 
// {
//     if (array[i] > 0)
//         positiveSum += array[i];
//     else
//         negativeSum += array[i];
// }
// Console.WriteLine($"Сумма положительных элементов массива {positiveSum}, сумма отрицательных элементов массива {negativeSum}");

// Вариант 2 (Bool)

int GetPasOrNegativSum(int[] array, bool pasOrNegative)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (pasOrNegative)
        {
            if (array[i] > 0)
                result += array[i];
        }
            else
            if (array[i] < 0)
                result += array[i];
    }
    return result;
}
int[] MakeNewRandomArray(int size, int beginValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(beginValue, endValue);
    return array;
}
int[] array = MakeNewRandomArray(12, -9, 9);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма положительных элементов массива {GetPasOrNegativSum(array, true)}");
Console.WriteLine($"Сумма отрицательных элементов массива {GetPasOrNegativSum(array, false)}");