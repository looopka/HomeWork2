int GetSecondGigit(int num)
{
    if (num < 100 || num > 999)
    {
        throw new ArgumentOutOfRangeException("Число должно быть трех значным");
    }

    return (num%100)/10;
}

Console.WriteLine("введи трехзначное число");
int.TryParse(Console.ReadLine(), out int num);
Console.WriteLine("вторая цифра это - " + GetSecondGigit(num));
