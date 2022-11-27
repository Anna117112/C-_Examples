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

int MinNumbers(int[] array)

{
    int min = 0;

    for (int i = 0; i < array.Length; i++)
    {
        min = array[0];

        if (array[i] < min)
        {

            min = array[i];

        }


    }
    System.Console.Write(min);
    return min;
}


int MaxNumbers(int[] array)

{
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        max = array[0];

        if (array[i] > max)
        {

            max = array[i];

        }


    }
    System.Console.Write(max);
    return max;
}


void DifferenceMinMaxNumber(int min, int max)
{

    int result = max - min;

    System.Console.Write($" -> {result}");
}

int[] array = GenerateRandomArray(3, 2, 10);
PrintArray(array);
int minNumber = MinNumbers(array);
int maxNumber = MaxNumbers(array);
DifferenceMinMaxNumber(minNumber, maxNumber);



