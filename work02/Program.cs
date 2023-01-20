// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numForCount = num;
int count = 0;

if(numForCount > 99)
{
    while(numForCount%10 != 0)
    {
        numForCount = numForCount/10;
        count++;
    }

int numForCalculation = Convert.ToInt32(num % Math.Pow(10, count-2));

    while(numForCalculation >= 10)
    {
        numForCalculation /= 10;
    }

    System.Console.WriteLine($"{num} -> {numForCalculation}");
}
else
{
    System.Console.WriteLine($"{num} -> третьей цифры нет");
}