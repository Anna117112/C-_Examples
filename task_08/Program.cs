
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void showInformationAboutQuarter(int xx1, int yy1, int xx2, int yy2, int zz1, int zz2)
{
    double distance = Math.Sqrt(Math.Pow(xx2 - xx1, 2) + Math.Pow(yy2 - yy1, 2) + Math.Pow(zz2 - zz1, 2));
    Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
    Console.ReadKey();

}

int x1 = getNumberFromUser("Введите X1:");
int y1 = getNumberFromUser("Введите Y1:");
int z1 = getNumberFromUser("Введите Z1:");
int x2 = getNumberFromUser("Введите X2:");
int y2 = getNumberFromUser("Введите Y2:");
int z2 = getNumberFromUser("Введите Z2:");
showInformationAboutQuarter(x1, y1, x2, y2, z1, z2);




