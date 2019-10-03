using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace task.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public String Name { get; set; }
        public String Adress { get; set; }
        public String Description { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}