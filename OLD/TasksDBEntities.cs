using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Solu_Tasks.Models
{
    public class TasksDBEntities
    {
        public DbSet<Task> Tasks { get; set; }
    }
}