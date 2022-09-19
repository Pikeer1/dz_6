// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] nums = new int [size];
Console.WriteLine("Созданный массив: ");

void Input(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int GetCompare(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Input(size);
Console.WriteLine($"Количество положительных элементов: {GetCompare(nums)}");


