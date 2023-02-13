// Could be the triangle with the specified sides


double[] GetArray()
{
    Console.WriteLine("Enter the lengths of the triangle sides: ");
    string[] str = Console.ReadLine().Split(" ");
    double[] arr = new double[3];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = Convert.ToDouble(str[i]);
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

bool CheckSides(double[] array)
{
    if ((array[2] < array[0] + array[1])
    && (array[0] < array[1] + array[2])
    && (array[1] < array[0] + array[2]))
        return true;
    else
        return false;

}

double[] arr = GetArray();
PrintArray(arr);
bool flag = CheckSides(arr);
if (flag)
    Console.WriteLine("Such a triangle can exist.");
else
    Console.WriteLine("Such a triangle cannot exist.");