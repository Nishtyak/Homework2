// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string number = Console.ReadLine();

int index = 0;
int min_lenght = 0;

void check_negative (string num, out int index, out int min_lenght)
{
    if(num.StartsWith("-")) 
    {
        index = 3;
        min_lenght = 4;
    }
    else
    {
        index = 2;
        min_lenght = 3;
    }
}

check_negative(number,out index,out min_lenght);

if(number.Length < min_lenght) Console.Write("Третьей цифры нет");
else Console.Write($"{number} -> {number[index]}");