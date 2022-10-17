// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber()
{
    int num = 0;
    while (num <= 1)
    {
        Console.WriteLine("Введите число (больше 1)!");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;     
}

int NumberDigits(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void GetSumm(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр равна {sum}");
}

int number = GetNumber();
int len = NumberDigits(number);
GetSumm(number, len);