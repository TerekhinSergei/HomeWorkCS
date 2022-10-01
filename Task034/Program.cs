// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//////////
Console.Clear();

Console.Write("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] nums = CreateArray(length);
PrintArray(nums);
Console.WriteLine($"количество четных элементов в массиве = {CountEvenElements(nums)}");

int[] CreateArray(int length)
{
    nums = new int[length];
    Random rand = new Random();    
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rand.Next(100, 1000);
    }
    return nums;
}
int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)            
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }    
}
