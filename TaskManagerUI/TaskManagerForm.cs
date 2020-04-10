using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TaskManager;
using Task = TaskManager.Task;
using TaskManager = TaskManager.TaskManager;

namespace TaskManagerUI
{
    public partial class TaskManagerForm : Form
    {
        private SetupForm setup;
        private global::TaskManager.TaskManager taskManager;

        public TaskManagerForm()
        {
            InitializeComponent();

            setup = new SetupForm();
        }

        private void button_setup_Click(object sender, EventArgs e)
        {
            setup.Show();
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            taskManager = new global::TaskManager.TaskManager(true);

            taskManager.Tasks = new List<Task>(setup.Tasks.ToArray());
            taskManager.ExecTime = setup.ExecTime;
            taskManager.PriorityUpdateInterval = setup.PriorityUpdateInterval;

            chartExec.Series.Clear();
            chartWait.Series.Clear();

            foreach (var task in taskManager.Tasks)
            {
                Series s1 = new Series
                {
                    ChartType = SeriesChartType.RangeBar,
                    Name = task.Name
                };
                chartExec.Series.Add(s1);

                Series s2 = new Series
                {
                    ChartType = SeriesChartType.RangeBar,
                    Name = task.Name
                };
                chartWait.Series.Add(s2);
            }

            taskManager.ExecuteAll();

            chartExec.ChartAreas[0].AxisY.ScaleView.Zoom(0, taskManager.LogTable.Count + 1);
            chartWait.ChartAreas[0].AxisY.ScaleView.Zoom(0, taskManager.LogTable.Count + 1);

            for (int i = 0; i < taskManager.LogTable.Count; i++)
            {
                var log = taskManager.LogTable[i];

                Series series = chartExec.Series.FindByName(log.InProgress);
                series?.Points.AddXY(1, i, i + 1);

                for (int j = 0; j < log.Ready.Count; j++)
                {
                    series = chartWait.Series.FindByName(log.Ready[j]);
                    series?.Points.AddXY(1, i, i + 1);
                }
                
            }
        }
    }
}
