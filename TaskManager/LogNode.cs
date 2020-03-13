using System.Collections.Generic;

namespace TaskManager
{
    public class LogNode
    {
        public int Time;
        public string InProgress;
        public List<string> Ready;

        public LogNode(int time, string inProgress, List<string> ready)
        {
            this.Time = time;
            this.InProgress = inProgress;
            this.Ready = ready;
        }
    }
}