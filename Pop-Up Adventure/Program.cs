using System;
using System.Threading;

namespace Pop_Up_Adventure
{
    class Program
    {
        static string Name;
        static string Sex;
        static string Age;
        static void Main(string[] args)
        {
            Console.Write("Loading Gaia Engine");
            Thinking();
            Thread.Sleep(3000);
            Console.Clear();
            GameBegin();
        }

        static void GameBegin()
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

        static void Introduction()
        {
            Console.Write("INTRODUCTION required!");
            ThinkingShort();
            Console.Clear();
            Console.Write("Loading GUI Introduction Interface");
            ThinkingShort();
            Thread.Sleep(2000);
            Console.Write("ERROR ERROR!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.Write("Low Power!");
            ThinkingShort();
            Console.WriteLine("");
            Console.WriteLine("Begin Diagnostics?");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Intiating Diagnostics");
            Thinking();           
            Console.Write("ACCESS DENIED !! ACCESS DENIED !!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Reverting to LEGACY Console interface");
            Thinking();
            Console.Write("INTRODUCTION required!");
            ThinkingShort();
            Console.Clear();
            Console.WriteLine("Enter First Name");
            Name = Console.ReadLine().ToString();
            Console.WriteLine();
            Console.Write("Saving");
            ThinkingShort();           
            Console.WriteLine("Accepted");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Enter Age");
            Age = Console.ReadLine().ToString();
            Console.WriteLine();
            Console.Write("Saving");
            ThinkingShort();
            Console.WriteLine("Accepted");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Enter Sex");
            Sex = Console.ReadLine().ToString();
            Console.WriteLine();
            Console.Write("Saving");
            ThinkingShort();
            Console.WriteLine("Accepted");
            Thread.Sleep(1500);
            Console.Clear();
            Console.Write("User Profile Accepted");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Loading LEGACY Console Interface");
            Thinking();
            ProgramStart();
        }
        
        static void ProgramStart()
        {

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
            Console.Clear();
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
