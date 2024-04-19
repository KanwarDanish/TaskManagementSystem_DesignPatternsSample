using System;
using System.Threading.Tasks;
using TaskManagementSystem.Adapter;
using TaskManagementSystem.Command;
using TaskManagementSystem.Singleton;
using TaskManagementSystem.State;

namespace TaskManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bindListBoxDataSource();

            cbxState.Items.Add("ToDo");
            cbxState.Items.Add("InProgress");
            cbxState.Items.Add("Done");
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskUI addTaskUI = new AddTaskUI(null);
            addTaskUI.ShowDialog();
            bindListBoxDataSource();
        }

        private void bindListBoxDataSource()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TaskRepository.Instance.tasks.Values.ToList();

            dataGridView1.Columns["State"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var task = dataGridView1.SelectedRows[0].DataBoundItem as Task;

                AddTaskUI addTaskUI = new AddTaskUI(task);
                addTaskUI.ShowDialog();
                bindListBoxDataSource();
            }

        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var task = dataGridView1.SelectedRows[0].DataBoundItem as Task;

                ICommand removeTaskCommand = new DeleteTaskCommand(task); //Command implimentation
                CommandInvoker commandInvoker = new CommandInvoker();
                commandInvoker.ExecuteCommand(removeTaskCommand);
                bindListBoxDataSource();
            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void btnLoadExternalTask_Click(object sender, EventArgs e)
        {
            ExternalTaskLoader externalTaskLoader = new ExternalTaskLoader(); //Adapter pattern applied
            var externalTasks = externalTaskLoader.LoadTasksFromFile("Text.txt");

            foreach (var item in externalTasks)
            {
                TaskAdapter taskAdapter = new TaskAdapter(item);
                Task task = taskAdapter.Adapt();

                if (task.IsCompleted)
                {
                    task.ChangeState(new DoneState());

                }
                else
                {
                    task.ChangeState(new ToDoState());
                }
                task.Handle();

                ICommand addTaskCommand = new AddTaskCommand(task); //Command implimentation
                CommandInvoker commandInvoker = new CommandInvoker();
                commandInvoker.ExecuteCommand(addTaskCommand);

            }



            bindListBoxDataSource();

        }

        private void btnChangeState_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var task = dataGridView1.SelectedRows[0].DataBoundItem as Task;
                var option = cbxState.Items[cbxState.SelectedIndex];

                if (option == "ToDo") //State implimentation
                {
                    task.ChangeState(new ToDoState());

                }
                else if (option == "InProgress")
                {
                    task.ChangeState(new InProgressState());

                }
                else if (option == "Done")
                {
                    task.ChangeState(new DoneState());

                }
                task.Handle();
                TaskManager.UpdateTask(task);
            }
            else
            {
                MessageBox.Show("Select Row");
            }

            bindListBoxDataSource();
        }
    }
}
