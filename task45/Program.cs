// Function that copies the array

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copy[i] = array[i];
    return copy;
}

int size = 12;
int[] arr = CreateRandomArray(size, -10, 10);
PrintArray(arr);
Console.WriteLine();
int[] copy = CopyArray(arr);
PrintArray(copy);