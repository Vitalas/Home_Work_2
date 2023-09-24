// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


bool DayOff(int num1)
{
    return num1 == 6 || num1 == 7;
}

Console.Write("Введите цифру дня недели 1-7 : ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 1) || (number > 7)) Console.WriteLine("Не корректный ввод.");
else
{
    bool result = DayOff(number);
    Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");
}
