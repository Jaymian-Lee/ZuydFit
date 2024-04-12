using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Member : Person
    {
        public int Progress { get; set; }
        public List<Activity> Activities { get; set; }

        public Member(int id, string name, int age, int progress) : base(name, age)
        {
            Id = id;
            Name = name;
            Age = age;
            Progress = progress;
        }

        public void participateSport()
        {
            return;
        }

        public void participateActivity() 
        { 
            return; 
        }

        public void showProgress()
        {
            return;
        }
    }
}
