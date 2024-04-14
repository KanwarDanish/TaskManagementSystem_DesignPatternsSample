using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Factory
{
    public class PersonalTask : ITaskFactory
    {
        const string Personal = "Personal";
        public Task CreateTask(string task, Priority priority, DateTime dueDate)
        {
            Task task1 = new Task();
            task1.Name = task;
            task1.Description = Personal;
            task1.DueDate = dueDate;
            task1.Priority = priority;
            //fill other details as well
            return task1;
        }
    }
}
