using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Center__Zainab_Alqattan_
{
    public interface ICommand
    {
        string Name { get; }
        void Execute(CommandCenter center);

    }
}
