
int[] GenerateRandomArray(int length)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(100, 999 + 1);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

void CountEvenNumbers(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 == 0)
        {
            summ++;
        }

    }
    System.Console.Write($" -> {summ} ");

}

int[] array = GenerateRandomArray(4);
PrintArray(array);
CountEvenNumbers(array);

