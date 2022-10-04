Console.Clear();

Console.Write("Введите количество чисел M: ");
int lenM = int.Parse(Console.ReadLine()!);
double[] nums = CreateArray(lenM);

Console.WriteLine($"\nВведены числа: {String.Join("; ", nums)}");
Console.WriteLine($"количество чисел больше 0 -> {CountPositiveElements(nums)}");

double[] CreateArray(int length)
{
    nums = new double[length];    
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        nums[i] = double.Parse(Console.ReadLine()!);         
    }
    return nums;
}
int CountPositiveElements(double[] array)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
