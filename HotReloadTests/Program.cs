using System;
using System.Threading;

class Program
{
    static bool running = true;

    static void Main()
    {
        int counter = 0;
        
        Console.WriteLine("Program started. Press Ctrl+C to stop.");

        while (running)
        {
            PrintCounter(counter);

            counter++;
            Thread.Sleep(2000);
        }
    }

    static void PrintCounter(int value)
    {
        if (value % 2 == 0)
        {
            Console.WriteLine($"[{DateTime.Now:T}] Even: {value}");
        }
        else
        {
            Console.WriteLine($"[{DateTime.Now:T}] Odd: {value}");
        }
    }
}