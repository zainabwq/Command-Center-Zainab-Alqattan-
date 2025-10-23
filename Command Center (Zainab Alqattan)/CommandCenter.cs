using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Center__Zainab_Alqattan_
{
    internal class CommandCenter
    {
        public string text { get; private set; }
        public string userName { get; private set; }
        public int commandProcessed { get; private set; }
        public bool isOperational { get; private set; }


        public void run()
        {

            Console.WriteLine("Welcome to the trainee command center! Enter a command or type 'help' for options.");

            text = Console.ReadLine();
            userName = "Guest";
            commandProcessed = 0;
            isOperational = true;


            while (isOperational)
            {
                commandProcessed++;

                if (text.ToLower() == "help")
                {
                    ShowHelp();
                    Console.WriteLine();

                    text = Console.ReadLine();
                }

                else if (text.ToLower() == "status")
                {

                    ShowStatus(userName);
                    Console.WriteLine($"Commands Processed: {commandProcessed} ");
                    Console.WriteLine();

                    text = Console.ReadLine();
                }

                else if (text.ToLower() == "set name" || text.ToLower() == "setname")
                {
                    userName = SetUserName();
                    Console.WriteLine();

                    text = Console.ReadLine();
                }

                else if (text.ToLower() == "exit")
                {
                    exitCommand();
                }

                else
                {
                    Console.WriteLine("______");
                    Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                    Console.WriteLine();

                    text = Console.ReadLine();
                }

            }

        }

        static void ShowHelp()
        {
            Console.WriteLine("______");
            Console.WriteLine("Available commands:");
            Console.WriteLine("   - help : Show available commands.");
            Console.WriteLine("   - status : Check the current status.");
            Console.WriteLine("   - set name : Change your name.");
            Console.WriteLine("   - exit : Exit the program.");
        }

        static void ShowStatus(string name, bool isOperational = true)
        {

            if (isOperational == true)
            {
                Console.WriteLine("______");
                Console.WriteLine($"Current status: Operational ");
                Console.WriteLine($"Current User: {name} ");
            }
            else
            {
                Console.WriteLine("______");
                Console.WriteLine($"Current status: Not Operational ");
                Console.WriteLine($"Current User: {name} ");
            }
        }

        static string SetUserName()
        {
            Console.WriteLine("______");
            Console.WriteLine("Enter your name:");
            string newName = Console.ReadLine();
            Console.WriteLine($"Thank you ({newName}), your name has been updated.");
            return newName;
        }

        static void exitCommand()
        {
            Console.WriteLine("______");
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);

        }
    }
}
