using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Activity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public Location Location { get; set; }

        public Activity(int id, string name, int points)
        {
            Id = id;
            Name = name;
            Points = points;
        }
    }
}
