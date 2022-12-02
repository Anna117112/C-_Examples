
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] generate2DArray(int lengthRow, int lengthCol, int lenght)
{
    int[,,] array = new int[lengthRow, lengthCol, lenght];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {


            for (int k = 0; k < lenght; k++)

            {
                array[i, j, k] = new Random().Next(10, 99 + 1);
            }
        }
    }
    return array;

}
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}
void print3dArrayForPossition(int[,,] array)
{


    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}{j}{k})");
            }
            Console.WriteLine();
        }
    }
}



int[,,] array = generate2DArray(2, 2, 2);
print3dArrayForPossition(array);

