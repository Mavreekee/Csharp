// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 100)
{
    Console.WriteLine("Третья цифра отсутствует");
}
else
{
    string number1 = number.ToString();
    Console.WriteLine($"Третья цифра - это {number1[2]}");
}