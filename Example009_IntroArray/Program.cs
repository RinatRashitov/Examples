int[] array1 = { 11, 21, 31, 411, 15, 61, 17, 18, 19 };
array1[0]=1201;

int count =1;
int max = array1[0];
while(count<9)
{
    if(max<array1[count]) max=array1[count];
    count = count +1;
}
Console.WriteLine(max);