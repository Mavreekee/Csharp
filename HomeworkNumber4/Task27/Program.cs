// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int result (int n1){
    string n2 = n1.ToString();
    int [] n3 = new int [n2.Length];
    int n4 = 0;
        for (int i = 0; i < n2.Length; i++){
            n3[i] = Convert.ToInt32(n2[i].ToString());
            n4 += n3[i];
            }
    return n4;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {number} = {result(number)}");