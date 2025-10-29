using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Center__Zainab_Alqattan_
{
    public class CommandCenter
    {
        private readonly Dictionary<string, ICommand> _commands;
        public string text { get; set; }
        public string userName { get; set; }
        public int commandProcessed { get; set; }
        public bool isOperational { get; set; }

        public CommandCenter()
        {
            _commands = new Dictionary<string, ICommand>
        {
            { "help", new ShowHelp() },
            { "status", new ShowStatus() },
            { "set name", new ShowName() }
        };
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the trainee command center! Enter a command or type 'help' for options.");
            Console.WriteLine();

           
            userName = "Guest";
            commandProcessed = 0;
            isOperational = true;


            while (isOperational)
            {
                commandProcessed++;
                text = Console.ReadLine();

                if (text == "exit")
                {
                    Console.WriteLine("______");
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }

                if (_commands.TryGetValue(text, out ICommand command))
                {
                    command.Execute(this);
                }
                else
                {
                    Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                    Console.WriteLine();
                }

            }

        }
    }
}
