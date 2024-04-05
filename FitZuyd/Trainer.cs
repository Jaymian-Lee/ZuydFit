using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Trainer : Member
    {

        public Activity Activity { get; set; }

        public Trainer(int id, string name, int age, int progress) : base(id, name, age, progress)
        {
            Id = id;
            Name = name;
            Age = age;
            Progress = progress;
        }

    }
}
