using System;

namespace TaskManager
{
    public class Task : IComparable
    {
        public string Name { get; }
        public int BasePriority { get; }
        public int LaunchTime { get; }
        public int ExecTime { get; }
        public int CoefPriorityUpdate { get; }
        public int Priority { get; private set; }
        public int Executed { get; private set; }
        public bool Done => Executed >= ExecTime;

        public Task(string name, int basePriority, int launchTime, int execTime, int coefPriorityUpdate)
        {
            this.Name = name;
            this.BasePriority = basePriority;
            this.LaunchTime = launchTime;
            this.ExecTime = execTime;
            this.CoefPriorityUpdate = coefPriorityUpdate;
            this.Priority = basePriority;
            this.Executed = 0;
        }

        public void Execute(int time)
        {
            Executed += time;
        }

        public void UpdatePriority(int newPriority)
        {
            Priority = newPriority;
        }

        public static Task GenerateRandomTask(string name)
        {
            Random rand = new Random(); 
            return new Task(name, rand.Next(10), rand.Next(100), rand.Next(10), rand.Next(10));
        }

        public int CompareTo(object obj)
        {
            return this.Priority.CompareTo(((Task) obj).Priority);
        }
    }
}