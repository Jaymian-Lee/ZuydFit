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
        public int? Id { get; set; } // Nullable Id property
        public string Name { get; set; } // Name of the location
        public string Address { get; set; } // Address of the location
        public List<Activity> Activities { get; set; } // List of activities associated with the location

        // Default constructor
        public Location()
        {
        }

        // Constructor to initialize a Location with name and address
        public Location(string name, string address)
        {
            Name = name;
            Address = address;
        }

        // Constructor to initialize a Location with id, name, and address
        public Location(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        // Method to save the location to the database
        public void SaveToDatabase()
        {
            DAL dal = new DAL();
            dal.CreateLocation(this);
        }

        // Method to get all locations from the database
        public DataTable GetAllLocations()
        {
            DAL dal = new DAL();
            return dal.GetAllLocation();
        }

        // Method to update the location in the database
        public void UpdateFromDatabase()
        {
            DAL dal = new DAL();
            dal.UpdateLocation(this);
        }

        // Method to delete the location from the database by id
        public void DeleteFromDatabase(int id)
        {
            DAL dal = new DAL();
            dal.DeleteLocation(id);
        }
    }
}