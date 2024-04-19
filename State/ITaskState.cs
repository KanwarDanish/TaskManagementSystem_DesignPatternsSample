using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.State
{
    public interface ITaskState //Behavioural Pattern, State, changes in state registered
    {
        void Handle(Task task);
    }

}
