using System;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
{
            //Indicates what appears on the screen
            Console.Write("This window will automatically close between... ");
            //Indicates a second from 10 to 0
            for (int a = 10; a >= 0; a--)
            {
                //Indicates the position of timer
                Console.CursorLeft = 50;
                //Indicates what appears on the screen: a
                Console.Write("{0} ", a);
                //Indicates the pause in milliseconds
                System.Threading.Thread.Sleep(1000);
   }
}
    }
}