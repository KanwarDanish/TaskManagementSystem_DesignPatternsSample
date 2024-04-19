namespace TaskManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lblTaskManagementSystem = new Label();
            btnAddTask = new Button();
            btnRemoveTask = new Button();
            btnEditTask = new Button();
            btnLoadExternalTask = new Button();
            btnChangeState = new Button();
            cbxState = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(227, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(867, 289);
            dataGridView1.TabIndex = 0;
            // 
            // lblTaskManagementSystem
            // 
            lblTaskManagementSystem.AutoSize = true;
            lblTaskManagementSystem.Location = new Point(582, 44);
            lblTaskManagementSystem.Name = "lblTaskManagementSystem";
            lblTaskManagementSystem.Size = new Size(179, 20);
            lblTaskManagementSystem.TabIndex = 1;
            lblTaskManagementSystem.Text = "Task Management System";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(291, 425);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "AddTask";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(440, 425);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(114, 29);
            btnRemoveTask.TabIndex = 3;
            btnRemoveTask.Text = "RemoveTask";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(622, 425);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(94, 29);
            btnEditTask.TabIndex = 4;
            btnEditTask.Text = "Edit Task";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnLoadExternalTask
            // 
            btnLoadExternalTask.Location = new Point(803, 425);
            btnLoadExternalTask.Name = "btnLoadExternalTask";
            btnLoadExternalTask.Size = new Size(160, 29);
            btnLoadExternalTask.TabIndex = 5;
            btnLoadExternalTask.Text = "Load External Task";
            btnLoadExternalTask.UseVisualStyleBackColor = true;
            btnLoadExternalTask.Click += btnLoadExternalTask_Click;
            // 
            // btnChangeState
            // 
            btnChangeState.Location = new Point(32, 136);
            btnChangeState.Name = "btnChangeState";
            btnChangeState.Size = new Size(122, 83);
            btnChangeState.TabIndex = 6;
            btnChangeState.Text = "ChangeState";
            btnChangeState.UseVisualStyleBackColor = true;
            btnChangeState.Click += btnChangeState_Click;
            // 
            // cbxState
            // 
            cbxState.FormattingEnabled = true;
            cbxState.Location = new Point(32, 268);
            cbxState.Name = "cbxState";
            cbxState.Size = new Size(154, 28);
            cbxState.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 511);
            Controls.Add(cbxState);
            Controls.Add(btnChangeState);
            Controls.Add(btnLoadExternalTask);
            Controls.Add(btnEditTask);
            Controls.Add(btnRemoveTask);
            Controls.Add(btnAddTask);
            Controls.Add(lblTaskManagementSystem);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTaskManagementSystem;
        private Button btnAddTask;
        private Button btnRemoveTask;
        private Button btnEditTask;
        private Button btnLoadExternalTask;
        private Button btnChangeState;
        private ComboBox cbxState;
    }
}
