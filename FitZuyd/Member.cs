using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Member
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Progress { get; set; }

        public Member(int id, string name, int age, int progress)
        {
            Id = id;
            Name = name;
            Age = age;
            Progress = progress;
        }

    }
}
