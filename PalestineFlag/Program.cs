using System;
class program
{
    public static void Main()
    {
        ConsoleColor current = Console.ForegroundColor;
        for (int i = 1; i < 22; i++)
        {
            int Counter = 0;
            // Red
            if (i < 12)
            {
                for (int j = 1; j <= i; j++) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("# ");
                    Counter++;
                }
            }
            else
            {
                for (int j = i; j < 22; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("# ");
                    Counter++;
                }
            }
            // Black
            if (i >= 1 && i < 7)
            {
                for (int j = 0; j < 41 - Counter; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("# ");
                }
            }
            // White
            if (i >= 7 && i < 16)
            {
                for(int j = 0;j <41-Counter; j++)
                {
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.Write("# ");
                }
            }
            // Green
            if(i >= 16 && i < 22)
            {
                for(int j =0 ;j <41-Counter; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }
}