int[] GenerateRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
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

void SummPositivNumbers(int[] array)

{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {

            summ += array[i];

        }

    }
    System.Console.Write($" -> {summ} ");
}

int[] array = GenerateRandomArray(3, 2, 10);
PrintArray(array);
SummPositivNumbers(array);

