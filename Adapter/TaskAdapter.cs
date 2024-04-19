using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Adapter
{
    public class TaskAdapter : Task //Adapter(Structural) to map incoming external task type to something we can have in our system
    {
        private ExternalTask externalTask;

        public TaskAdapter(ExternalTask externalTask)
        {
            this.externalTask = externalTask;

        }

         public Task Adapt()
        {
            Task task = new Task
            {
                ID = externalTask.TaskID,
                Name = externalTask.TaskName,
                Description = externalTask.TaskDescription,
                Priority = (Priority)Enum.Parse(typeof(Priority), externalTask.Priority),
                DueDate = externalTask.Deadline,
                IsCompleted = externalTask.IsCompleted
            };
            return task;
        }
    }
}
