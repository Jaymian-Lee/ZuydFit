﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public Location Location { get; set; }
    }
}
