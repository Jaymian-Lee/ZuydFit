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
        public int LocationId { get; set; }

        // Default constructor
        public Activity()
        {
        }

        // Constructor to initialize an Activity with name, points, and locationId
        public Activity(string name, int points, int locationId)
        {
            Name = name;
            Points = points;
            LocationId = locationId;
            Location = GetLocation(); // Retrieve location upon creation
        }

        // Constructor to initialize an Activity with id, name, points, and locationId
        public Activity(int id, string name, int points, int locationId)
        {
            Id = id;
            Name = name;
            Points = points;
            LocationId = locationId;
            Location = GetLocation(); // Retrieve location upon creation
        }

        // Constructor to initialize an Activity with id only
        public Activity(int id)
        {
            Id = id;
        }

        // Method to retrieve all activities from the database
        public DataTable GetAllActivities()
        {
            DAL dal = new DAL();
            return dal.GetAllActivities();
        }

        // Method to save the activity to the database
        public void SaveToDatabase(Activity activity)
        {
            DAL dal = new DAL();
            dal.AddActivity(activity);
        }

        // Method to update the activity in the database
        public void UpdateFromDatabase(Activity activity)
        {
            DAL dal = new DAL();
            dal.UpdateActivity(activity);
        }

        // Method to delete the activity from the database by id
        public void DeleteFromDatabase(int id)
        {
            DAL dal = new DAL();
            dal.DeleteActivity(id);
        }

        // Method to retrieve location information from the database
        public Location GetLocation()
        {
            DAL dal = new DAL();
            return dal.GetLocationById(LocationId);
        }
    }
}
