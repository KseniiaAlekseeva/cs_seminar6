// Calculate Fibonacci series without recursion

int[] Fibonacci(int num)
{
    if (num > 0)
    {
        int[] array = new int[num];
        if (num > 1)
            array[1] = 1;
        array[0] = 0;

        for (int i = 2; i < num; i++)
        {
            array[i] = array[i - 2] + array[i - 1];
        }
        return array;
    }
    else
    {
        int[] array = new int[] { -1 };
        return array;
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

Console.WriteLine("Enter the positive integer number N for fibonacci series:");
int num = int.Parse(Console.ReadLine());
PrintArray(Fibonacci(num));

