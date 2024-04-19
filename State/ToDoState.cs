using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.State
{
    public class ToDoState : ITaskState
    {
        public void Handle(Task task)
        {
            task.StateMessage = $"Task '{task.Name}' is in 'To Do' state.";
            Console.WriteLine(task.StateMessage);
            task.IsCompleted = false; //set iscompleted only here
        }
    }
}
