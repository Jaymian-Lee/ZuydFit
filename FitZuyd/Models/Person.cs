using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Person(string name, int age, string username, string password)
        {
            Name = name;
            Age = age;
            Username = username;
            Password = password;

        }
    }
}
