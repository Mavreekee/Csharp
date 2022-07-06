// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
Console.WriteLine("Задайте размерность массива m х n");
Console.Write("Введите m: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [row,column];
for (int i = 0; i < row; i++)
{
for (int j = 0; j < column; j++)
{
    matrix[i,j] = new Random().Next(0,10);
    Console.Write(matrix[i,j] + " " );
}
Console.WriteLine();
}
double sum = 0;
int count = 0;
    for (int j = 0; j < column; j++)
    {
        for (int i = 0; i < row; i++)
        {
            sum = sum + matrix[i,j];
            if (i == row - 1)
            {
            Console.WriteLine($"Среднее арифметическое {count}-го столбца равно {Math.Round(sum/row,2)}");
            sum = 0;
            count = count + 1;
            }
        }
    }