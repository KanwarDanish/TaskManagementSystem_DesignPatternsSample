using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Adapter
{
    public class ExternalTaskLoader
    {
        public List<ExternalTask> LoadTasksFromFile(string filePath)
        {
            List<ExternalTask> tasks = new List<ExternalTask>();

            // Read lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Parse each line and create ExternalTask objects
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                ExternalTask task = new ExternalTask
                {
                    TaskID = int.Parse(values[0]),
                    TaskName = values[1],
                    TaskDescription = values[2],
                    Priority = values[3],
                    Deadline = DateTime.Parse(values[4]),
                    IsCompleted = bool.Parse(values[5])
                };
                tasks.Add(task);
            }

            return tasks;
        }
    }
}
