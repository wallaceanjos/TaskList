using System;
using System.Collections.Generic;
using System.Text;

namespace TaskList.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDetails { get; set; }
    }
}
