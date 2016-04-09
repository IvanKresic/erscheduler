using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace erscheduler.Models
{
    public class Work_Data
    {
        [Key]
        public int Work_Data_ID { get; set; }
        public DateTime Shift_Date_End { get; set; }
        public DateTime Shift_Time_End { get; set; }
        public int Working_Hours { get; set; }
    }
}