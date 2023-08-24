Console.WriteLine("Сколько чисел отобразить?");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

int[] GetFib (int[] arr)
{
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

GetFib(array);

Console.WriteLine($"[{String.Join(",", array)}]");