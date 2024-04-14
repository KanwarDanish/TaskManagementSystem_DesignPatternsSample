using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Singleton;

namespace TaskManagementSystem
{
    internal class TaskManager
    {
        private TaskRepository taskRepository;

        public TaskManager()
        {
            taskRepository = TaskRepository.Instance;
        }

        public void AddTask(Task task)
        {
            taskRepository.AddTask(task);
        }

        public void DeleteTask(int id)
        {
            taskRepository.DeleteTask(id);
        }

        public Task GetTask(int id)
        {
            return taskRepository.GetTask(id);
        }

        // Add methods for updating tasks, marking as completed, etc.
    }
}
