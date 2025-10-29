using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Center__Zainab_Alqattan_
{
    public class ShowHelp : ICommand
    {
        public string Name = "help";

        string ICommand.Name => throw new NotImplementedException();

        public void Execute(CommandCenter center)
        {
            Console.WriteLine("______");
            Console.WriteLine("Available commands:");
            Console.WriteLine("   - help : Show available commands.");
            Console.WriteLine("   - status : Check the current status.");
            Console.WriteLine("   - set name : Change your name.");
            Console.WriteLine("   - exit : Exit the program.");
            Console.WriteLine();
        }
    }
}
