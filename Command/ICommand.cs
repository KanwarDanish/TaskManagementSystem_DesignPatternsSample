using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Command
{
    public interface ICommand //Command Pattern, Behavioural, Changes add or delete for the pattern
    {
        void Execute();
        void Undo();
    }
}
