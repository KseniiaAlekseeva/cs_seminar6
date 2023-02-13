// Convert a decimal number to binary

int ConvertToBinary(int num)
{
    string str = "";
    int curnum = num;

    do
    {
        str = Convert.ToString(curnum % 2) + str;
        curnum = curnum / 2;
    }
    while (curnum != 0);

    int binum = Convert.ToInt32(str);
    return binum;
}

Console.WriteLine("Enter the decimal integer number: ");
int num = int.Parse(Console.ReadLine());

int binum = ConvertToBinary(num);
Console.WriteLine(binum);