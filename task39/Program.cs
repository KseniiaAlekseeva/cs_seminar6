// Reverse an array

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

void ReverseArray(int[] array)
{
    int cur = 0;
    int N = array.Length;
    for (int i = 0; i < N / 2; i++)
    {
        cur = array[i];
        array[i] = array[N - i - 1];
        array[N - i - 1] = cur;
    }
}

int size = 12;
int[] arr = CreateRandomArray(size, -10, 10);
PrintArray(arr);
Console.WriteLine();
ReverseArray(arr);
PrintArray(arr);

