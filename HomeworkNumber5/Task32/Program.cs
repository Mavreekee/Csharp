// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
Console.Write("Введите длину массива: ");
int maslenght = Convert.ToInt32(Console.ReadLine());
int [] masran = new int [maslenght];
for (int i = 0; i < masran.Length; i++){
    masran[i]  = new Random().Next(-10,11);
};
Console.Write("Исходный массив: [");
for (int i = 0; i < masran.Length - 1; i++){
    Console.Write($"{masran[i]}, ");
}
Console.Write($"{masran[masran.Length - 1]}");
Console.Write("]");
masrandom(masran);
void masrandom (int [] n1){
    for (int i = 0; i < n1.Length; i++){
        n1[i] = n1[i] * -1;
    }
    Console.Write("\nМассив после преобразований: [");
    for (int i = 0; i < n1.Length - 1; i++){
        Console.Write($"{n1[i]}, ");
    }
Console.Write($"{n1[n1.Length - 1]}");
Console.Write("]");
}