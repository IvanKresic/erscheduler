using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace erscheduler.Models
{
    public class Employees
    {
        public int ID { get; set; }
        public string Employment { get; set; }
        public int OIB { get; set; }
        public int Priority { get; set; }
        public bool Status { get; set; }
    }
}