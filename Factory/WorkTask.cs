using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Factory
{
    public class WorkTask : ITaskFactory
    {
        const string Work = "Work";
        public Task CreateTask(string task, Priority priority, DateTime dueDate)
        {
            Task task1 = new Task();
            task1.Name = task;
            task1.Description = Work;
            task1.Priority = priority;
            task1.DueDate = dueDate;
            //fill other details as well

            return task1;
        }

       
    }
}
