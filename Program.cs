using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите цифру, обозначающую день недели:");
        int day = int.Parse(Console.ReadLine());

        if (day == 6 || day == 7)
        {
            Console.WriteLine("День является выходным.");
        }
        else
        {
            Console.WriteLine("День не является выходным.");
        }
    }
}