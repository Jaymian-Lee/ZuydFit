using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Trainer : Person
    {

        public Activity Activity { get; set; }

        public Trainer(int id, string name, int age) : base(name, age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    }
}
