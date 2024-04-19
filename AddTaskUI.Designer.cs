namespace TaskManagementSystem
{
    partial class AddTaskUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            cbxPriority = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            cbxIsCompleted = new CheckBox();
            btnCreate = new Button();
            button2 = new Button();
            cbxDesc = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 93);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 138);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Priority";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 186);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "DueDate";
            // 
            // txtName
            // 
            txtName.Location = new Point(321, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            // 
            // cbxPriority
            // 
            cbxPriority.FormattingEnabled = true;
            cbxPriority.Location = new Point(318, 138);
            cbxPriority.Name = "cbxPriority";
            cbxPriority.Size = new Size(151, 28);
            cbxPriority.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(319, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // cbxIsCompleted
            // 
            cbxIsCompleted.AutoSize = true;
            cbxIsCompleted.Enabled = false;
            cbxIsCompleted.Location = new Point(96, 233);
            cbxIsCompleted.Name = "cbxIsCompleted";
            cbxIsCompleted.Size = new Size(115, 24);
            cbxIsCompleted.TabIndex = 10;
            cbxIsCompleted.Text = "IsCompleted";
            cbxIsCompleted.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(94, 364);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(551, 366);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbxDesc
            // 
            cbxDesc.FormattingEnabled = true;
            cbxDesc.Location = new Point(322, 92);
            cbxDesc.Name = "cbxDesc";
            cbxDesc.Size = new Size(151, 28);
            cbxDesc.TabIndex = 14;
            // 
            // AddTaskUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxDesc);
            Controls.Add(button2);
            Controls.Add(btnCreate);
            Controls.Add(cbxIsCompleted);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbxPriority);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddTaskUI";
            Text = "AddTaskUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private ComboBox cbxPriority;
        private DateTimePicker dateTimePicker1;
        private CheckBox cbxIsCompleted;
        private Button btnCreate;
        private Button button2;
        private ComboBox cbxDesc;
    }
}