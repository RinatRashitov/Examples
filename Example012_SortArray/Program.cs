/*Нужно осртировать массив от минимума к макимуму*/

int[] array = { 8, 4, 2, 5, 8, 5, 3, 2, 9, 7, 1 };
int count = array.Length;
int i = 0;
int j = 1;
int min = 0;
int minIndex = 0;
int tmpArray = 0;
for (i = 0; i < count-1; i++)
{
    min = array[i];
    minIndex = i;
    for (j = i+1; j < count; j++)
    {
        if (min > array[j])
        {
            min = array[j];
            minIndex = j;
        }
    }
    tmpArray = array[i];
    array[i] = min;
    array[minIndex] = tmpArray;
    //min = 0;
    //minIndex = 0;
}

for (i = 0; i < count; i++)
{
    Console.Write(array[i] + ", ");
}