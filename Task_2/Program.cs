//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num1 = num;

while (num > 0)
{
    int num2 = num % 10;
    num = num / 10;
    sum = sum + num2;
}
Console.WriteLine($"Сумма цифр числа {num1} равна: {sum}");
