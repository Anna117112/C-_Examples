/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных э
лементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 
*/
int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}



int summNumber(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return 0;
    }


    return numberM + summNumber(numberM + 1, numberN);

    //Console.Write(numberN + ", ");

}

int numberM = getUserInt("Введите число M");
int numberN = getUserInt("Введите число N");
int result = summNumber(numberM, numberN);
System.Console.WriteLine(result);
