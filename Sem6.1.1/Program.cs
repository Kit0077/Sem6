Console.WriteLine("Сколько будет чисел?");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Колличетсво принимаемых цифр равно {array.Length}");
    Console.WriteLine("Введите число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int result (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

 Console.WriteLine($"Колличетсво чисел больше 0 равно: {result(array)}");
// Console.WriteLine($"{String.Join("", array)}");