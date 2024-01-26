// 2024-01-26. Домашнее задание. Рекурсия

// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

System.Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());;
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());;

if (M==N)
{
    Console.WriteLine("Вы ввели одно и то же число: " + M+". Попробуйте снова.");
}

else
{
int minNum=Int32.Min(M,N);
int maxNum=Int32.Max(M,N);
PrintNumbers(minNum, maxNum);
}

void PrintNumbers(int firstNum, int lastNum)
{
    if(firstNum>lastNum)
    {
        return;
    }
    System.Console.Write(firstNum+"\t");
    PrintNumbers(firstNum+1, lastNum);
}


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

System.Console.WriteLine("Введите неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите неотрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else if (x > 0 && y == 0)
    {
        return AckermannFunction(x - 1, 1);
    }
    else
    {
        return AckermannFunction(x - 1, AckermannFunction(x, y - 1));
    }
}

Console.WriteLine($"A({m},{n}) = {AckermannFunction(m,n)}");

