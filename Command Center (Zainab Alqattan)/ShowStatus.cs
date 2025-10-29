using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Center__Zainab_Alqattan_
{
    public class ShowStatus : ICommand
    {
        public string Name = "status";

        string ICommand.Name => throw new NotImplementedException();

        public void Execute(CommandCenter center)
        {
            Console.WriteLine("______");
            Console.WriteLine($"Current status:  {center.isOperational} ");
            Console.WriteLine($"Current User: {center.userName} ");
            Console.WriteLine($"Commands Processed: {center.commandProcessed} ");
            Console.WriteLine();

        }
    }
}
