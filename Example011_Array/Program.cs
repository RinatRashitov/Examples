void FillArray(int[] coolection)
{
    int length = coolection.Length;
    int index = 0;
    while (index < length)
    {
        coolection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int len = col.Length;
    int position = 0;
    while (position < len)
    {
        Console.Write(Convert.ToString(col[position]) + ", ");
        position++;
    }
}

int IndexOf(int[] colection, int Find)
{
    int len = colection.Length;
    int index = 0;
    int position = -1;
    while (len > index)
    {
        if (Find == colection[index])
        {
            position = index;
            break;
        }
        index++;
    }
    return(position);
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine("");

int pos = IndexOf(array, 5);
Console.WriteLine(pos);