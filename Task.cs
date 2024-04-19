using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.State;

namespace TaskManagementSystem
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public ITaskState State { get; set; }
        public string StateMessage { get; set; }

        public void ChangeState(ITaskState state)
        {
            State = state;
        }

        public void Handle()
        {
            State.Handle(this);
        }
    }

    public enum Priority { 
    Low, Medium, High
    }
}
