using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Trainer : Person
    {

        public List<Activity> Activities { get; set; }
        public List<Location> Locations { get; set; }

        public Trainer(int id, string name, int age) : base(name, age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void addLocation() 
        {
            return;
        }

        public void addActivity()
        {
            return;
        }

    }
}
