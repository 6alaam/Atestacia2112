Main();

void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("enter command");
        string command = Console.ReadLine();
        switch (command)
        {
            case "Task 1":
                Task1();
                break;
            case "Task 2":
                Task2();
                break;
            case "Task 3":
                Task3();
                break;
            case "exit":
                isWork = false;
                break;

        }
    }
}


// Задача(1) 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void Task1()
{
    Console.WriteLine("Введите число M");
    int m = ReadInt("m");
    Console.WriteLine("Введите число N ");
    int n = ReadInt("n");
    if (m == n)
    {
        Console.WriteLine("Числа равны");

    }
    else
    {
        NauralNumbers(m, n);
    }



}

// Задача(2) 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Task2()
{
    Console.WriteLine("Введите число M");
    int m = ReadInt("m");
    Console.WriteLine("Введите число N ");
    int n = ReadInt("n");
    if (m == n)
    {
        Console.WriteLine("Числа равны");

    }
    else
    {
        Console.WriteLine(NaturalSum(m, n));
    }

}

// Задача(3) 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 (в неверном порядке указаны числа, при таких значениях функция равна 9 , если же m = 3 а n =2 тогда ответ 29)

void Task3()
{
     Console.WriteLine("Введите число M");
    int m = ReadInt("m");
    Console.WriteLine("Введите число N ");
    int n = ReadInt("n");
    Console.WriteLine(ack(m,n));

}




int ReadInt(string argument)
{

    Console.Write($"Input {argument}: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("Не число введите число!");

    }
    return number;

}

void NauralNumbers(int a, int b)
{

    if (a > b)
    {
        for (int i = b; i <= a; i++)
        {
            Console.Write(i);
        }
    }

    else
    {
        for (int i = a; i <= b; i++)
        {
            Console.Write(i);
        }
    }
    Console.WriteLine("");

}

int NaturalSum(int a, int b)
{
    int sum = 0;
    if (a > b)
    {
        for (int i = b; i <= a; i++)
        {
            sum += i;
        }
    }

    else
    {
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
    }
    return sum;

}



int ack(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return ack(n - 1, 1);
    }
    else
    {
        return ack(n - 1, ack(n, m - 1));
    }


}
