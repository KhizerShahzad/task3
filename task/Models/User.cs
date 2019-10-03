using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace task.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String Country { get; set; }
        public String Adress { get; set; }
        public String Description { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public int DepartmentId { get; set; }
 
        [ForeignKey("DepartmentId")]
        public Department department { get; set; }

    }
}