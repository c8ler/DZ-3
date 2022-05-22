/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите координату X точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

var dlina = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
Console.WriteLine("Расстояние между точками равно " + string.Format("{0:N2}", dlina));