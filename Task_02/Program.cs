// Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] MyArray(int length,int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random(); 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] InvertArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int size = 12;
int minValue = -9;
int maxValue = 9;

int[] myArray = MyArray(size, minValue, maxValue);
PrintArray(myArray);
InvertArray(myArray);
PrintArray(myArray);


