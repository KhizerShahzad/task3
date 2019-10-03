
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace task.Models
{
    public class datacontroller : DbContext
    {
        public datacontroller() : base("name=employedata")
        {
        }
            public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<User> Users { get; set; }

    
    }
}
