// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * -1;

if ((number < 100) || (number > 1000)) Console.WriteLine("Не корректный ввод.");
else Console.WriteLine(SecondDigit(number));

int SecondDigit(int num)
{
    int numDuble = number / 10;
    int secondDigit = numDuble % 10;
    return secondDigit;
}