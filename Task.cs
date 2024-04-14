using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    public enum Priority { 
    Low, Medium, High
    }
}
