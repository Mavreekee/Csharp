//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
Console.Write("Введите длину массива: ");
int maslenght = Convert.ToInt32(Console.ReadLine());
double [] mas = new double [maslenght];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i]  = Math.Round((new Random().NextDouble()) * 10, 2);
    }
searchmaxmin(mas);
void searchmaxmin (double [] mas)
{
    double max = mas[0];
    double min = mas[0];
    double diff = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > max)
        {
            max = mas[i];
        }
    }
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < min)
        {
            min = mas[i];
        }
    }
    diff = Math.Round((max - min), 2);
    Console.Write("Массив: [");
    for (int i = 0; i < mas.Length - 1; i++){
        Console.Write($"{mas[i]} ; ");
    }
    Console.Write($"{mas[mas.Length - 1]}");
    Console.Write("]");
    Console.Write($"\nМаксимальный элемент массива = {max}");
    Console.Write($"\nМинимальный элемент массива = {min}");
    Console.Write($"\nРазница между максимальным и минимальным элементом массива = {diff}");
}