// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Задайте размерность прямоугольного массива rows x colums");
Console.Write("Введите rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите colums = ");
int colums = Convert.ToInt32(Console.ReadLine());
if (rows == colums)
{
   Console.WriteLine("Вы задали квадратный массив"); 
}
else
{
int [,] matrix = new int [rows,colums];
Console.WriteLine();
Console.WriteLine("Исходный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);
        Console.Write(matrix[i,j] + " ");
    }
Console.WriteLine();
}
Console.WriteLine();

sumrows(matrix);
void sumrows (int [,] matrix)
{
    int sum = 0;
    int min = 0;
    int minSum = 0;
    int [] mass = new int [rows];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        sum = sum + matrix[i,j];
    }
Console.WriteLine($"Сумма {i} строки = {sum}");
mass[i] = sum;
sum = 0;
}
for (int i = 0; i < rows; i++)
{
    if (mass[i] < min)
    {
        min = mass [i];
        minSum = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов находится на {minSum} строке и равна {min}");
}
}