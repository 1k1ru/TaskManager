using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TaskManager
{
    public class TaskManager
    {
        public List<Task> Tasks { get; private set; }
        public int UpdatePriorityInterval { get; private set; }
        public int ExecTime { get; private set; }
        public bool Logging { get; set; }

        public int Time { get; private set; }
        public Task InProgress { get; private set; }
        public int InProgressTime { get; private set; }
        public List<Task> Ready { get; private set; }
        
        public List<LogNode> LogTable { get; private set; }

        public TaskManager(List<Task> tasks, int updatePriorityInterval, int execTime, bool logging = false)
        {
            this.Tasks = tasks;
            this.UpdatePriorityInterval = updatePriorityInterval;
            this.ExecTime = execTime;
            this.Logging = logging;

            Time = 0;
            InProgressTime = 0;
            Ready = new List<Task>();

            if (Logging)
            {
                LogTable = new List<LogNode>();
            }
        }

        public void ExecuteAll()
        {
            while (Tasks.Count > 0 || Ready.Count > 0 || InProgress != null)
            {
                Step();
            }
        }

        public void Step()
        {
            if (InProgress != null)
            {
                if (InProgress.Done)
                {
                    InProgress = null;
                }
                else if (InProgressTime == ExecTime)
                {
                    Ready.Add(InProgress);
                    InProgress = null;
                }
            }

            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].LaunchTime == Time)
                {
                    Ready.Add(Tasks[i]);
                    Tasks.RemoveAt(i--);
                }
            }

            if (Time % UpdatePriorityInterval == 0)
            {
                UpdatePriorities();
            }

            Ready.Sort();

            if (InProgress == null && Ready.Count > 0)
            {
                InProgress = Ready.Last();
                Ready.Remove(InProgress);
                InProgressTime = 0;
            }

            if (InProgress != null)
            {
                InProgress.Execute(1);
                InProgressTime++;
            }

            if (Logging)
            {
                List<string> readyTasks = new List<string>;
                foreach (var task in Ready)
                {
                    readyTasks.Add(task.Name);
                }

                LogTable.Add(new LogNode(Time, InProgress.Name, readyTasks));
            }

            Time++;
        }

        private void UpdatePriorities()
        {
            foreach (var task in Ready)
            {
                task.UpdatePriority(task.BasePriority + task.CoefPriorityUpdate * (Time - task.LaunchTime) * (Time - task.LaunchTime));
            }
        }
    }
}