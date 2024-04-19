using System;
using System.Collections.Generic;
using System.Data;
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

        public Activity() 
        {

        }   
        public Activity(int id, string name, int points)
        {
            Id = id;
            Name = name;
            Points = points;
        }

        public DataTable GetAllActivities()
        {
            DAL dal = new DAL();
            return dal.GetAllActivities();
        }

        public void SaveToDatabase()
        {
            DAL dal = new DAL();
            dal.AddActivity(this);
        }

        public void UpdateFromDatabase()
        {
            DAL dal = new DAL();
            dal.UpdateActivity(this);
        }
        public void DeleteFromDatabase(int id)
        {
            DAL dal = new DAL();
            dal.DeleteActivity(id);
        }
    }
}
