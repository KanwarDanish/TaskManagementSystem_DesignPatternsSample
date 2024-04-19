using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Command
{
    public class DeleteTaskCommand : ICommand
    {
        private Task task;

        public DeleteTaskCommand(Task task)
        {
            this.task = task;
        }

        public void Execute()
        {
            TaskManager.DeleteTask(task.ID);
        }

        public void Undo()
        {
            TaskManager.AddTask(task);
        }
    }
}
