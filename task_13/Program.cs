/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/


int[] getRange(int length)
{
    int[] array = new int[length];
    Random rd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rd.Next(0, 2);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] array = getRange(8);
printArray(array);
