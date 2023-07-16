string GetThirdDigit(int num)
{
    if (num < 100)
        return "Нет третьего числа";
    string result = num.ToString()[2].ToString();
    return result;
}
Console.WriteLine("введи число");
int.TryParse(Console.ReadLine(), out int num);
Console.WriteLine("Ответ - " + GetThirdDigit(num));
