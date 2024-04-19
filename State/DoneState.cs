using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.State
{
    public class DoneState : ITaskState
    {
        public void Handle(Task task)
        {
            task.StateMessage = $"Task '{task.Name}' is in 'Done' state.";
            Console.WriteLine(task.StateMessage);
            task.IsCompleted = true ; //set iscompleted only here
        }
    }
}
