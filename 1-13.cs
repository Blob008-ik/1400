using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.Write("31 18 79");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("47  52  150");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(50);
        Console.WriteLine(10);
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(5);
        Console.WriteLine(10);
        Console.WriteLine(21);
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine();

        Console.WriteLine();
        double pi = 3.1415926;
        Console.WriteLine(pi.ToString("F3"));
        Console.WriteLine();

        Console.WriteLine();
        double e = 2.71828;
        Console.WriteLine(e.ToString("F1"));
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("Введите число: ");
        string input1 = Console.ReadLine();
        Console.WriteLine($"Вы ввели число {input1}");
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("Введите число: ");
        string input2 = Console.ReadLine();
        Console.WriteLine($"{input2} – вот какое число Вы ввели");
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("Введите ваше имя: ");
        string name1 = Console.ReadLine();
        Console.WriteLine(name1);
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("Введите название футбольной команды: ");
        string team = Console.ReadLine();
        Console.WriteLine($"{team} – это чемпион!");
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("Введите имя: ");
        string name2 = Console.ReadLine();
        Console.WriteLine($"Привет, {name2}!");
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Следующее за числом {number} число – {number + 1}");
        Console.WriteLine($"Для числа {number} предыдущее число – {number - 1}");
        Console.WriteLine();

        Console.ReadKey();
    }
}
