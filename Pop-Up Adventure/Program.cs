using System;
using System.Threading;

namespace Pop_Up_Adventure
{
    class Program
    {
        string Name;
        string sex;
        string age;
        static void Main(string[] args)
        {
            Console.Write("Loading Gaia Engine");
            Thinking();
            Thread.Sleep(3000);
            Console.Clear();
            GameBegin();
        }

        private static void GameBegin()
        {
            Console.Write("Login Using Stored Credentials?");
            Console.WriteLine("");

            String Firstchoice = Console.ReadLine().ToString();
            if (Firstchoice == "y")
            {
                Console.Clear();
                Console.Write("Authenticating");
                Thinking();
                Console.Clear();
                Console.WriteLine("Welcome AUTHENTICATED USER");
                Thread.Sleep(2000);
                Console.Clear();
                
            }
            else
            { 
                Console.Write("Calculating");
                Thinking();
                Console.WriteLine(" ShutDown Initiated.");
                Thread.Sleep(3000);
                return;
            }      
                        
            Thread.Sleep(1000);            
            Console.Clear();
            Introduction();
        }

        private static void Introduction()
        {
            Console.Write("INTRODUCTION required!");
            ThinkingShort();
            Console.Clear();
            Console.Write("Loading GUI Introduction Interface");
            Thinking();
            Thread.Sleep(2000);
            Console.Write("ERROR ERROR!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.Write("Low Power!");
            Thinking();
            Console.WriteLine("");
            Console.WriteLine("Begin Diagnostics?");
            Console.ReadLine();

        }

        static void Thinking()
        {
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
        }
        static void ThinkingShort()
        {
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}
