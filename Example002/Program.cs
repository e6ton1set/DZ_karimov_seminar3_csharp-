//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetSumNum (int number)
{   
    int sum = 0;
    number = Math.Abs(number);
    for (int i = 0; number > 0; i++)
    {
        sum = sum + number % 10;
        number = number /10;
    }
    return sum;
}

try
{
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetSumNum(number);
Console.WriteLine($"Положительная сумма всех чисел числа {number} = {result}");
}

catch
{
   Console.WriteLine("Пожалуйста, введите целое число.");
}