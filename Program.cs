using FakeItEasy;
using System;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            // My Logo
            Thread.Sleep(750);
            Console.WriteLine("               -- --    -----    -----    -- --   -- --    --                ");
            Console.WriteLine("               -----    --       --       -- --   -----    --                ");
            Console.WriteLine("               -----    -----    -----    -----   -----    --                ");
            Console.WriteLine("               -- --    --          --    -- --   -- --    --                ");
            Console.WriteLine("               -- --    -----    -----    -- --   -- --    --                ");
            //Set A Timer Duration
            Console.WriteLine("Write a Timer Duration (seconds)...");
            //Read Input
            Console.WriteLine("Enter a number");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", duration);
            //Indicates a second from "input" to 0
            for (int a = duration; a >= 0; a--)
            {
            //Duration "input"
                int duration5 = (duration--);
            // Customize Text And Color
            Console.ForegroundColor = ConsoleColor.Green;
            //Indicates what appears on the screen:
                Console.Write("{0} ", duration5);
            //Indicates the pause in milliseconds
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}