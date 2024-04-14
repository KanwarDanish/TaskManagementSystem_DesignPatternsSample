using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Factory
{
    public interface ITaskFactory //FACTORY INTERFACE(Creational pattern)..This will serve to create different type of tasks from the same factory
    {
        Task CreateTask(string task, Priority priority, DateTime dueDate);
    }
}
