using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace erscheduler.Models
{
    public class Worker
    {
        
        public int ID { get; set; }
        public int OIB { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth_Date { get; set; }
        public char Gender { get; set; }
        public string Adress { get; set; }
        public int Hometown { get; set; }
        public int Home_Telephone { get; set; }
        public int Mobile_Phone { get; set; }
        public string Note { get; set; }
    }
}