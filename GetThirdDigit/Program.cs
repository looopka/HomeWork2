string GetThirdDigit(int num)
{
    if (num < 100)
        return "Нет третьего числа";
    while (num > 999)
    {
        num /= 10;
    }
    return (num%10).ToString();
}
Console.WriteLine("введи число");
int.TryParse(Console.ReadLine(), out int num);
Console.WriteLine("Ответ - " + GetThirdDigit(num));
