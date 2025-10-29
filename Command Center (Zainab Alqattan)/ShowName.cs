using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Center__Zainab_Alqattan_
{
    public class ShowName : ICommand
    {

        public string Name = "set name";

        string ICommand.Name => throw new NotImplementedException();

        public void Execute(CommandCenter center)
        {
            Console.WriteLine("______");
            Console.WriteLine("Enter your name:");
            string newName = Console.ReadLine();
            center.userName = newName;
            Console.WriteLine($"Thank you ({center.userName}), your name has been updated.");
            Console.WriteLine();

        }
    }
}
