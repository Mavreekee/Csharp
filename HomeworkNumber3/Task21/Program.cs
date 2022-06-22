// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.Write("Введите координату по X для первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по Y для первой точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по Z для первой точки: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по X для второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками = {distance}");