using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFluentValidAPI.Reminder
{
    public class Reminder
    {
        public string Message { get; set; }
        public DateTime TriggerTime { get; set; }
        public bool IsTriggered { get; set; } = false;
    }
}
