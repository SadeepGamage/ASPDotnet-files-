using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class TaskModel
    {
        public int Id { set; get; }
        public string Title { set; get; } =string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}