﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace erscheduler.Models
{
    public class Branchess
    {
        public int Branchess_ID { get; set; }
        public string ParentBranch { get; set; }
        public string EmergencyAmbulance { get; set; }
        public int OIB { get; set; }
    }
}