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

        public int ID => externalTask.TaskID;

        public string Name => externalTask.TaskName;

        public  string Description => externalTask.TaskDescription;

        public  string Priority => externalTask.Priority;

        public DateTime DueDate => externalTask.Deadline;

        public bool IsCompleted => externalTask.IsCompleted;
    }
}
