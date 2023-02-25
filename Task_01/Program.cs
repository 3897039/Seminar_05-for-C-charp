// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

int[] MyArray(int length,int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random(); //создание генератора случ чисел
    // цикл заполнения массива случ числами из диапозона между minvalue ьфчмфдгу
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//ф-ция возвращает сумму положит элементов
int SumPositive(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum += array[i];
        }
   }
   return sum;
}

int SumNegative(int[] array)
{
    int summer = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            summer += array[i];
        }
   }
   return summer;
}

int size = 12;
int minValue = -9;
int maxValue = 9;
int[] array = MyArray(size, minValue, maxValue);
ShowArray(array);
int sumPositive = SumPositive(array);
int sumNegative = SumNegative(array);
Console.WriteLine($"Сумма положительных элементов массива равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNegative}");


