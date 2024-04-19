using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Adapter;
using TaskManagementSystem.Command;
using TaskManagementSystem.Factory;
using TaskManagementSystem.State;

namespace TaskManagementSystem
{
    public partial class AddTaskUI : Form
    {
        Task EditTaskUI;
        public AddTaskUI(Task task)
        {
            InitializeComponent();
            EditTaskUI = task;
            
            cbxPriority.DataSource = Enum.GetValues(typeof(Priority));
            cbxDesc.Items.Add("Work");
            cbxDesc.Items.Add("Personal");
            if (EditTaskUI!=null)
            {
               txtName.Text=EditTaskUI.Name;
                cbxDesc.Text=EditTaskUI.Description;
                cbxPriority.SelectedItem = EditTaskUI.Priority;
                dateTimePicker1.Value=EditTaskUI.DueDate;
                cbxIsCompleted.Checked=EditTaskUI.IsCompleted;
                btnCreate.Text = "Update";
            }
            else
            {
                btnCreate.Text = "Create";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var desc = cbxDesc.Text;
            var priority = cbxPriority.SelectedItem;
            var dueDate = dateTimePicker1.Value;
            var isCompleted = cbxIsCompleted.Checked;

            if (EditTaskUI!=null)
            {
                EditTaskUI.Name = name;
                EditTaskUI.Description = desc;
                EditTaskUI.DueDate = dueDate; 
                EditTaskUI.IsCompleted = isCompleted;
                EditTaskUI.Priority = (Priority)Enum.Parse(typeof(Priority), priority.ToString());

                TaskManager.UpdateTask(EditTaskUI);
            }
            else
            {
                ITaskFactory taskFactory=null; //Factory implimentation
                if (desc.Equals("Work"))
                {
                    taskFactory = new WorkTask();
                }
                else if (desc.Equals("Personal"))
                {
                    taskFactory = new PersonalTask();
                }

                var task = taskFactory.CreateTask(name, (Priority)priority, dueDate);

                task.ChangeState(new ToDoState()); //State implimentation
                task.Handle();


                ICommand addTaskCommand = new AddTaskCommand(task); //Command implimentation
                CommandInvoker commandInvoker = new CommandInvoker();
                commandInvoker.ExecuteCommand(addTaskCommand);

            }


            this.Close();
        }
    }
}
