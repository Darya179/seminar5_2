int[] array = getArray(10, 0, 20);

int[] getArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

int Kol(int[] arr)
{
    int Sum = 0;

    for (int i = 1; i < arr.Length; i = i+2)
    {
        Sum = Sum + arr[i];
    }

    return Sum;
}

Console.WriteLine($"Сумма нечетных элементов массива : { Kol(array) }");