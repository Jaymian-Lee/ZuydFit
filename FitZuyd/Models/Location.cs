﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Location
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Activity> Activities { get; set; }

        public Location(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}