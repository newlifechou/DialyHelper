﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialyHelper.Models
{
    public class Plan
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime  StartTime { get; set; }
        public DateTime  EndTime { get; set; }
        public int Priority { get; set; }
        public bool IsFinished { get; set; }
        public string Remark { get; set; }
        public bool NeedRemind { get; set; }
        public DateTime RemindTime { get; set; }

    }
}