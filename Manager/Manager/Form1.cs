namespace Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonAddTask.Enabled = false;
            buttonRemoveTask.Enabled = false;
            buttonFinishTask.Enabled = false;
            DateTime timeStamp = DateTime.Now;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e) { toolStripStatusLabelClock.Text = DateTime.Now.ToString("HH:mm:ss"); }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTaskName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBoxTaskList.HorizontalScrollbar = true;
                listBoxTaskList.Items.Add(textBoxTaskName.Text + " - Started at " + toolStripStatusLabelClock.Text);
                toolStripStatusLabelTotal.Text = "Total tasks: " + (listBoxTaskList.Items.Count + listBoxCompletedTasks.Items.Count);
                toolStripStatusLabelIncomplete.Text = "Incomplete: " + listBoxTaskList.Items.Count;
                buttonFinishTask.Enabled = true;
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (textBoxTaskName.Text.Length == 0)
            {
                MessageBox.Show("Isn't possible add blank tasks.");
                textBoxTaskName.Focus();
            }
            else
            {
                listBoxTaskList.HorizontalScrollbar = true;
                listBoxTaskList.Items.Add(textBoxTaskName.Text + " - Started at " + toolStripStatusLabelClock.Text);
                buttonRemoveTask.Enabled = true;
                buttonFinishTask.Enabled = true;
                toolStripStatusLabelTotal.Text = "Total tasks: " + (listBoxTaskList.Items.Count + listBoxCompletedTasks.Items.Count);
                toolStripStatusLabelIncomplete.Text = "Incomplete: " + listBoxTaskList.Items.Count;
            }
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTaskList.Focus())
            {
                if (listBoxTaskList.SelectedItem is not null)
                {
                    listBoxTaskList.Items.Remove(listBoxTaskList.SelectedItem);
                    toolStripStatusLabelTotal.Text = "Total tasks: " + (listBoxTaskList.Items.Count + listBoxCompletedTasks.Items.Count);
                    toolStripStatusLabelIncomplete.Text = "Incomplete: " + listBoxTaskList.Items.Count;
                }
                if (listBoxTaskList.Items.Count <= 0)
                {
                    buttonRemoveTask.Enabled = false;
                    buttonFinishTask.Enabled = false;
                }
            }
        }

        private void textBoxTaskName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTaskName.Text == "")
            {
                buttonAddTask.Enabled = false;
            }
            else
            {
                buttonAddTask.Enabled = true;
            }
        }

        private void buttonFinishTask_Click(object sender, EventArgs e)
        {
            if (listBoxTaskList.SelectedItem is not null)
            {
                listBoxCompletedTasks.Enabled = true;
                listBoxCompletedTasks.HorizontalScrollbar = true;
                listBoxCompletedTasks.Items.Add(listBoxTaskList.SelectedItem + " and finished at " + toolStripStatusLabelClock.Text);
                listBoxTaskList.Items.Remove(listBoxTaskList.SelectedItem);
                toolStripStatusLabelCompleted.Text = "Completed: " + listBoxCompletedTasks.Items.Count;
                //toolStripStatusLabelTotal.Text = "Total tasks: " + listBoxTaskList.Items.Count;
                toolStripStatusLabelIncomplete.Text = "Incomplete: " + listBoxTaskList.Items.Count;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
