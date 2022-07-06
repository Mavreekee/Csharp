// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Уравнения двух прямых:");
Console.WriteLine("Прямая №1: y = k1 * x + b1");
Console.WriteLine("Прямая №2: y = k2 * x + b2");
Console.WriteLine("Необходимо задать переменные");
point();
void point ()
{
    Console.Write("Введите значение k1 = ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение b1 = ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение k2 = ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение b2 = ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine($"Две прямые параллельны друг другу");
    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Две прямые лежат друг на друге");
    }
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * ((b2 - b1)/(k1 - k2)) + b1;
        Console.WriteLine($"Координата точки пересечения двух прямых: ({x}; {y})");
    }
}