using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Singleton
{
    public class TaskRepository //SINGLETON IMPLIMENTATION
    {
        private static TaskRepository instance;
        private Dictionary<int, Task> tasks = new Dictionary<int, Task>();
        private int nextID = 1;

        // Private constructor to prevent instantiation
        private TaskRepository() { }

        // Singleton instance getter
        public static TaskRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaskRepository();
                }
                return instance;
            }
        }

        public void AddTask(Task task)
        {
            task.ID = nextID++;
            tasks.Add(task.ID, task);
        }

        public void DeleteTask(int id)
        {
            if (tasks.ContainsKey(id))
            {
                tasks.Remove(id);
            }
        }

        public Task GetTask(int id)
        {
            return tasks.ContainsKey(id) ? tasks[id] : null;
        }

        // Add methods for updating tasks, marking as completed, etc.
    }

}
