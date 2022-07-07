﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_3
{
    public class EmployeeProject
    {
        public int Id { get; set; } 
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeId { get; set; } 
        public int ProjectId { get; set; }
        public  Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
