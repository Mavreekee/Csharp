// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int row = new Random().Next(1,10);
int column = new Random().Next(1,10);
int [,] mass = new int [row,column];
for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
{
    mass[i,j] = new Random().Next(-10,10);
}
}
search(mass);
void search (int [,] mass)
{
    Console.WriteLine("Давайте попробуем найти элемент в массиве");
    Console.Write("Введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int A = 0;
    int B = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (i == m && j == n)
            {
            A = A + mass[i,j];
            B = B + 1;
            }
        }
    }
    if (B > 0)
    {
    Console.Write($"Элемент на позиции [{m},{n}] = {A}");
    }
    else
    {
    Console.Write($"Элемент на позиции [{m},{n}] не найден в данном массиве");
    }
    Console.WriteLine();
    Console.WriteLine($"Исходный массив размерностью {mass.GetLength(0)} х {mass.GetLength(1)}:");
    for (int i = 0; i < mass.GetLength(0); i++)
    {
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " " );
    }
    Console.WriteLine();
    }
}
