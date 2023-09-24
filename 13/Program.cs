// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdDigit);

int ThirdDigit(int num);
if (number < 0) number = number * -1;
if (number > 999)
{
    while (number > 999)
        number = number / 10;
}
int thirdDigit = number % 100,
return thirdDigit;
Console.WriteLine(ThirdDigit);


