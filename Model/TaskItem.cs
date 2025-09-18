using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowLog.Core
{

    public enum TaskStatus
    {
        Not started
        Started,
        Completed,
        Waiting,
        Stored
    }
    public class TaskItem
    {
        private ststic _nextId = 1;

        public int ID {get;}
        public string Name {get; set;} = string.empty;
        public string? Overview {get; set;};
        public DateOnly? CountDay{get; set;};
        public TaskStatus Status {get; set;};

        piblic TaskItem()
        {
            ID = _nextId++;
        }

    }
}
