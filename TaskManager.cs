using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Singleton;

namespace TaskManagementSystem
{
    public static class TaskManager
    {
        private static TaskRepository taskRepository;

        static TaskManager()
        {
            taskRepository = TaskRepository.Instance;
        }

        public static void AddTask(Task task)
        {
            taskRepository.AddTask(task);
        }

        public static void DeleteTask(int id)
        {
            taskRepository.DeleteTask(id);
        }

        public static Task GetTask(int id)
        {
            return taskRepository.GetTask(id);
        }

        public static void UpdateTask(Task task)
        {
             taskRepository.UpdateTask(task);
        }


        // Add static methods for updating tasks, marking as completed, etc.
    }

}
