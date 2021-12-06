using System;
using System.Threading;

class Program
{
    static int ProgBarLength = 50;
    static int origRow;

    static void UpdateBar(int progress)
    {
        int numChars = progress * ProgBarLength / 100;
        Console.SetCursorPosition(0, origRow);
        Console.Write("[");
        for(int i = 0; i < numChars; i++)
        {
            Console.Write("=");
        }
        for(int i = 0; i < ProgBarLength - numChars - 1; i++)
        {
            Console.Write(" ");
        }
        Console.Write("]");
    }

    static void Main()
    {
        for(int i = 0; i < 100; i++)
        {
            origRow = Console.CursorTop;
            UpdateBar(i);
            Thread.Sleep(10);
        }
        Console.WriteLine("\nDone!");
    }
}
