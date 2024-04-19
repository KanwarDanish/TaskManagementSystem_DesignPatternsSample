using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Command
{
    public class AddTaskCommand : ICommand
    {
        private Task task;

        public AddTaskCommand(Task task)
        {
            this.task = task;
        }

        public void Execute()
        {
            TaskManager.AddTask(task);
        }

        public void Undo()
        {
            TaskManager.DeleteTask(task.ID);
        }
    }
}
