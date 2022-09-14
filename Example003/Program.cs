//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void printArray (int size) 
{
    int [] array = new int [size];
    Console.WriteLine("\nВведите элементы массива по порядку");
    
    for (int i = 0; i < size; i++)
    {
        int tmp = int.Parse(Console.ReadLine());    
        array[i] = tmp;
    }
    for (int i = 0; i < size; i++)
    {
         Console.WriteLine($"\nЭлемент с индексом {i} равен {array[i]}");
    }
}

Console.WriteLine("\nВведите количество элементов в массиве");
int size = int.Parse(Console.ReadLine());
printArray(size);


