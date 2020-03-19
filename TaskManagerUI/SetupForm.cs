using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = TaskManager.Task;

namespace TaskManagerUI
{
    public partial class SetupForm : Form
    {
        public List<Task> Tasks { get; private set; }
        public int ExecTime { get; private set; }
        public int PriorityUpdateInterval { get; private set; }

        public SetupForm()
        {
            InitializeComponent();

            Tasks = new List<Task>();
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if (name.Text.Length == 0 || basePriority.Text.Length == 0 || launchTime.Text.Length == 0 || execTime.Text.Length == 0 || priorityUpdateCoef.Text.Length == 0)
            {
                MessageBox.Show("Fill all task settings fields.", "Error");
                return;
            }

            if (taskList.Items.Contains(name.Text))
            {
                MessageBox.Show("Task with this name already exist.", "Error");
                return;
            }

            try
            {
                int basePr = int.Parse(basePriority.Text);
                int launchT = int.Parse(launchTime.Text);
                int execT = int.Parse(execTime.Text);
                int prUpdC = int.Parse(priorityUpdateCoef.Text);

                Task task = new Task(name.Text, basePr, launchT, execT, prUpdC);
                Tasks.Add(task);

                taskList.Items.Add(name.Text);

                name.Text = "";
                basePriority.Text = "";
                launchTime.Text = "";
                execTime.Text = "";
                priorityUpdateCoef.Text = "";

            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid task settings.", "Error");
                return;
            }
        }

        private void removeTask_Click(object sender, EventArgs e)
        {
            taskList.Items.Remove(taskList.SelectedItem);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            try
            {
                ExecTime = int.Parse(tb_globalExecTime.Text);
                PriorityUpdateInterval = int.Parse(tb_priorityUpdateInterval.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid global settings.", "Error");
                return;
            }

            this.Hide();
        }

        private void SetupForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
