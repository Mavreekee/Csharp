// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Console.Write("Введите длину массива: ");
int maslenght = Convert.ToInt32(Console.ReadLine());
int [] masran = new int [maslenght];
for (int i = 0; i < masran.Length; i++){
    masran[i]  = new Random().Next(1,11);
}
masrandom(masran);
void masrandom (int [] n1){
    Console.Write("Введите число, которое нужно найти в массиве: ");
    int search = Convert.ToInt32(Console.ReadLine());
    int searchcount = 0;
    for (int i = 0; i < n1.Length - 1; i++){
        if (n1[i] == search){
            searchcount++;
        }
    }
    if (searchcount >= 1){
        Console.WriteLine($"Число {search} присутствует в массиве");
    }
    else{
        Console.WriteLine($"Число {search} отсутствует в массиве");
    }
    Console.Write("Исходный массив: [");
    for (int i = 0; i < n1.Length - 1; i++){
            Console.Write($"{n1[i]}, ");
    }
    Console.Write($"{n1[n1.Length - 1]}");
    Console.Write("]");
}