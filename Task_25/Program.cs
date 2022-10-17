// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetNumb(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ExpoNum (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

int numberA = GetNumb("Введите число A: ");
int numberB = GetNumb("Введите число B: ");
ExpoNum(numberA, numberB);