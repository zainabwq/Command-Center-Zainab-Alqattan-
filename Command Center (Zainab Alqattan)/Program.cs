using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Center__Zainab_Alqattan_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Welcome to the trainee command center! Enter a command or type 'help' for options.");

            string text = Console.ReadLine();
            string userName = "Guest";
            int commandProcessed = 0;



            while (commandProcessed >= 0)
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
