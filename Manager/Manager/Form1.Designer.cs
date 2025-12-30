namespace Manager
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            textBoxTaskName = new TextBox();
            listBoxTaskList = new ListBox();
            buttonAddTask = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelTotal = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelCompleted = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabelIncomplete = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabelClock = new ToolStripStatusLabel();
            label2 = new Label();
            listBoxCompletedTasks = new ListBox();
            label3 = new Label();
            buttonRemoveTask = new Button();
            buttonFinishTask = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Task: ";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(480, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(90, 35);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(295, 23);
            textBoxTaskName.TabIndex = 2;
            textBoxTaskName.TextChanged += textBoxTaskName_TextChanged;
            textBoxTaskName.KeyUp += textBoxTaskName_KeyUp;
            // 
            // listBoxTaskList
            // 
            listBoxTaskList.FormattingEnabled = true;
            listBoxTaskList.ItemHeight = 15;
            listBoxTaskList.Location = new Point(90, 64);
            listBoxTaskList.Name = "listBoxTaskList";
            listBoxTaskList.Size = new Size(295, 169);
            listBoxTaskList.TabIndex = 3;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(391, 35);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(75, 23);
            buttonAddTask.TabIndex = 4;
            buttonAddTask.Text = "Add";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTotal, toolStripStatusLabel1, toolStripStatusLabelCompleted, toolStripStatusLabel2, toolStripStatusLabelIncomplete, toolStripStatusLabel3, toolStripStatusLabelClock });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(480, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotal
            // 
            toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            toolStripStatusLabelTotal.Size = new Size(67, 17);
            toolStripStatusLabelTotal.Text = "Total tasks: ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(22, 17);
            toolStripStatusLabel1.Text = "  |  ";
            // 
            // toolStripStatusLabelCompleted
            // 
            toolStripStatusLabelCompleted.Name = "toolStripStatusLabelCompleted";
            toolStripStatusLabelCompleted.Size = new Size(72, 17);
            toolStripStatusLabelCompleted.Text = "Completed: ";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(22, 17);
            toolStripStatusLabel2.Text = "  |  ";
            // 
            // toolStripStatusLabelIncomplete
            // 
            toolStripStatusLabelIncomplete.Name = "toolStripStatusLabelIncomplete";
            toolStripStatusLabelIncomplete.Size = new Size(73, 17);
            toolStripStatusLabelIncomplete.Text = "Incomplete: ";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(28, 17);
            toolStripStatusLabel3.Text = "   |   ";
            // 
            // toolStripStatusLabelClock
            // 
            toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            toolStripStatusLabelClock.Size = new Size(37, 17);
            toolStripStatusLabelClock.Text = "Clock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Pending: ";
            // 
            // listBoxCompletedTasks
            // 
            listBoxCompletedTasks.Enabled = false;
            listBoxCompletedTasks.FormattingEnabled = true;
            listBoxCompletedTasks.ItemHeight = 15;
            listBoxCompletedTasks.Location = new Point(90, 244);
            listBoxCompletedTasks.Name = "listBoxCompletedTasks";
            listBoxCompletedTasks.Size = new Size(295, 169);
            listBoxCompletedTasks.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 244);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 8;
            label3.Text = "Completed: ";
            // 
            // buttonRemoveTask
            // 
            buttonRemoveTask.Location = new Point(391, 64);
            buttonRemoveTask.Name = "buttonRemoveTask";
            buttonRemoveTask.Size = new Size(75, 23);
            buttonRemoveTask.TabIndex = 9;
            buttonRemoveTask.Text = "Remove";
            buttonRemoveTask.UseVisualStyleBackColor = true;
            buttonRemoveTask.Click += buttonRemoveTask_Click;
            // 
            // buttonFinishTask
            // 
            buttonFinishTask.Location = new Point(391, 210);
            buttonFinishTask.Name = "buttonFinishTask";
            buttonFinishTask.Size = new Size(75, 23);
            buttonFinishTask.TabIndex = 10;
            buttonFinishTask.Text = "Finish task";
            buttonFinishTask.UseVisualStyleBackColor = true;
            buttonFinishTask.Click += buttonFinishTask_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(buttonFinishTask);
            Controls.Add(buttonRemoveTask);
            Controls.Add(label3);
            Controls.Add(listBoxCompletedTasks);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Controls.Add(buttonAddTask);
            Controls.Add(listBoxTaskList);
            Controls.Add(textBoxTaskName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(496, 489);
            MinimumSize = new Size(496, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Common Task Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private TextBox textBoxTaskName;
        private ListBox listBoxTaskList;
        private Button buttonAddTask;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelTotal;
        private ToolStripStatusLabel toolStripStatusLabelCompleted;
        private ToolStripStatusLabel toolStripStatusLabelIncomplete;
        private Label label2;
        private ListBox listBoxCompletedTasks;
        private Label label3;
        private Button buttonRemoveTask;
        private Button buttonFinishTask;
        private ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}
