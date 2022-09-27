// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.Clear();
int[] nums;
int length = 8;
CreateArray(length);
PrintArray(nums);

void CreateArray(int length)
{
    nums = new int[length];
    Random rand = new Random();    
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rand.Next();
    }
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
