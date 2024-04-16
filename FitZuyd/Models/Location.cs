using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class Location
    {

        public int? Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Activity> Activities { get; set; }

        public Location()
        {
        }

        public Location(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Location(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public void SaveToDatabase()
        {
            DAL dal = new DAL();
            dal.CreateLocation(this);
        }

        public DataTable GetAllLocations()
        {
            DAL dal = new DAL();
            return dal.GetAllLocation();
        }

        public void UpdateFromDatabase()
        {
            DAL dal = new DAL();
            dal.UpdateLocation(this);
        }
    }
}
