int number = 165465465;
int index = 1;
int a = 1;
int number2 = number;
if(number / 100 >0)
{
    while (number > 10)
    {
        index = index + 1;
        number = number / 10;
    }
    while (index > 3)
    {
        a = a * 10;
        index = index - 1;
    }
    Console.WriteLine($"третья цифра {number2 / a % 10}");
}
else
{
    Console.WriteLine("нет третьей цифры");
}
