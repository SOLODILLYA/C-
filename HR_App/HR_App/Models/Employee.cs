﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_App.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepId { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }
    }
}
