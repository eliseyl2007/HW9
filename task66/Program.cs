/*Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1)
{
Console.WriteLine("Ошибка ввода!");
return;
}

void NateralNumbers(int num1, int num2)
{
if (num1 > num2)
{
Console.Write($"{num1} ");
NateralNumbers(num1 - 1, num2);
}
else if (num1 < num2)
{
Console.Write($"{num1} ");
NateralNumbers(num1 + 1, num2);
}
else Console.Write($"{num1} ");
}

NateralNumbers(number1, number2);

int SumNaturalNumbers(int num1, int num2)
{
    int result = num1;
    if (num1 == num2) return 0;
    else if (num1 > num2)
    {
        num1++;
        result = num1 + SumNaturalNumbers(num1, num2);
        return result;
    }
    else
    {
        num1--;
        result = num1 + SumNaturalNumbers(num1, num2);
        return result;
    }
}

int sumNaturalNumbers = SumNaturalNumbers(number1, number2);
Console.WriteLine($"Сумма между ваших чисел = {sumNaturalNumbers}");*/


Console.Write("Введите первое натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

SumbetweenNum1ToNum2(number1, number2);

// вызов функции "сумма чисел от M до N"
void SumbetweenNum1ToNum2(int number1, int number2)
{
    Console.Write(Sumbetween(number1 - 1, number2));
}

// функция сумма чисел от M до N
int Sumbetween(int number1, int number2)
{
    int res = number1;
    if (number1 == number2)
        return 0;
    else
    {
        number1++;
        res = number1 + Sumbetween(number1, number2);
        return res;
    }
}
