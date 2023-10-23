Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

AkermanFunc(number1, number2);


void AkermanFunc(int num1, int num2)
{
    Console.WriteLine(AkermanFunctCalculation(num1, num2));
}

int AkermanFunctCalculation(int numb1, int numb2)
{
    if (numb1 == 0)
    {
        return numb2 + 1;
    }
    else if (numb2 == 0 && numb1 > 0)
    {
        return AkermanFunctCalculation(numb1 - 1, 1);
    }
    else
    {
        return (AkermanFunctCalculation(numb1 - 1, AkermanFunctCalculation(numb1, numb2 - 1)));
    }
}