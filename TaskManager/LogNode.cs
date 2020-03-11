using System.Collections.Generic;

namespace TaskManager
{
    public class LogNode
    {
        public int Time;
        public Task InProgress;
        public List<Task> Ready;

        public LogNode(int time, Task inProgress, List<Task> ready)
        {
            this.Time = time;
            this.InProgress = inProgress;
            this.Ready = ready.GetRange(0, ready.Count);
        }
    }
}