string IsHolyday(int num)
{
    if (num >= 1 && num <= 7)
    {
        switch (num)
        {
            case 6:
                return "Да";
            case 7:
                return "Да";
            default:
                return "Нет";
        }
    }
    else { throw new ArgumentException("Допустимые значения 1-7"); }
}

Console.WriteLine("введи день недели цифрой");
int.TryParse(Console.ReadLine(), out int num);
Console.WriteLine("Это выходной?  - " + IsHolyday(num));