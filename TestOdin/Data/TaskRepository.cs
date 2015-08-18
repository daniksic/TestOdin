using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestOdin.Models;

namespace TestOdin.Data
{
    public class TaskRepository : RepositoryBase<Task>
    {
        public TaskRepository(IEnumerable<Task> tasks): base(tasks)
        {
        }

        
    }
}
