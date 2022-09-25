int[] array = {new Random().Next(1, 50),
new Random().Next(1, 50), new Random().Next (1, 50),
new Random().Next(1, 50), new Random().Next(1, 50),
new Random().Next(1, 50), new Random().Next(1, 50),
new Random().Next(1, 50), new Random().Next(1, 50),
new Random().Next(1, 50), new Random().Next(1, 50),
new Random().Next(1, 50), new Random().Next (1, 50) };
int n = array.Length;
Console.WriteLine($"Длина массива {n} элементов");
int count = 0;
while (count < n)
{
    Console.Write(Convert.ToString(array[count]) + ", ");
    count = count + 1;
}
Console.WriteLine("Введите искомое значение");
int findNumber = Convert.ToInt32(Console.ReadLine());
count =0;
int nbreak = 0;
while(count<n)
{
    if(findNumber==array[count])
    {
        Console.WriteLine($"Индекс искомого значения - {count}");
        nbreak = 1;
        break;
    }
    count =count+1;
}
if(nbreak == 0) Console.WriteLine("Искомое значение не найдено.");