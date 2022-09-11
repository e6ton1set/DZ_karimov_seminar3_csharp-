// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Решить задачу с использованием методов.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int SearchDegree(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));

    return result;
}

try
{
    Console.Write("Input A: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Input B: ");
    int b = int.Parse(Console.ReadLine());

    int result = SearchDegree(a, b);
    Console.WriteLine($"Число {a} в степени {b} = {result}");
}

catch
{
    Console.WriteLine("Пожалуйста, введите число.");
}