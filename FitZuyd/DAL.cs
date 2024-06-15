using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitZuyd
{
    public class DAL
    {
        // Connection string to the database - Jay
        // public string conString = "Data Source=desktop-ir29ng7;Initial Catalog=FitZuyd;Integrated Security=True;";

        // Connection string to the database - Lars
        public string conString = "Data Source=.;Initial Catalog=FitZuyd;Integrated Security=True";
        public SqlConnection cnn;

        // Constructor to initialize the SQL connection
        public DAL()
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
        }

        // DataAccessLayer for Member

        // Method to get all members from the database
        public DataTable GetAllCustomers()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Member";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }
        }

        // Method to add a new member to the database
        public void AddMember(Member member)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "insert into Member (Name, Age, Progress, Username, Password) values (@Name, @Age, @Progress, @Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", member.Name);
                    cmd.Parameters.AddWithValue("@Age", member.Age);
                    cmd.Parameters.AddWithValue("@Progress", member.Progress);
                    cmd.Parameters.AddWithValue("@Username", member.Username);
                    cmd.Parameters.AddWithValue("@Password", member.Password);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        // Method to update an existing member in the database
        public void UpdateMember(Member member)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "update Member set Name = @Name, Age = @Age, Progress = @Progress where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", member.Id);
                    cmd.Parameters.AddWithValue("@Name", member.Name);
                    cmd.Parameters.AddWithValue("@Age", member.Age);
                    cmd.Parameters.AddWithValue("@Progress", member.Progress);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        // Method to delete a member from the database by id
        public void DeleteMember(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "delete from Member where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        // DataAccessLayer for Trainer

        /// <summary>
        /// Get all trainers from the database and put them in a DataTable
        /// </summary>
        /// <returns>DataTable containing all trainers</returns>
        public DataTable GetAllTrainers()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Trainer";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }
        }

        /// <summary>
        /// Add a trainer to the database with the constructor values of Trainer
        /// </summary>
        /// <param name="trainer">Trainer object containing the details of the trainer</param>
        public void AddTrainer(Trainer trainer)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "insert into Trainer (Name, Age, Username, Password) values (@Name, @Age, @Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", trainer.Name);
                    cmd.Parameters.AddWithValue("@Age", trainer.Age);
                    cmd.Parameters.AddWithValue("@Username", trainer.Username);
                    cmd.Parameters.AddWithValue("@Password", trainer.Password);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        /// <summary>
        /// Update a trainer in the database with the constructor values of Trainer
        /// </summary>
        /// <param name="trainer">Trainer object containing the updated details of the trainer</param>
        public void UpdateTrainer(Trainer trainer)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "update Trainer set Name = @Name, Age = @Age where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", trainer.Id);
                    cmd.Parameters.AddWithValue("@Name", trainer.Name);
                    cmd.Parameters.AddWithValue("@Age", trainer.Age);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        /// <summary>
        /// Delete a trainer from the database by id
        /// </summary>
        /// <param name="id">Id of the trainer to be deleted</param>
        public void DeleteTrainer(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "delete from Trainer where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        // DataAccessLayer for Activity

        /// <summary>
        /// Get all activities from the database and put them in a DataTable
        /// </summary>
        /// <returns>DataTable containing all activities</returns>
        public DataTable GetAllActivities()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Activity";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }
        }

        /// <summary>
        /// Add an activity to the database with the constructor values of Activity
        /// </summary>
        /// <param name="activity">Activity object containing the details of the activity</param>
        public void AddActivity(Activity activity)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "insert into Activity (Name, Points, LocationId) values (@Name, @Points, @LocationId)";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", activity.Name);
                    cmd.Parameters.AddWithValue("@Points", activity.Points);
                    cmd.Parameters.AddWithValue("@LocationId", activity.LocationId);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        /// <summary>
        /// Update an activity in the database with the constructor values of Activity
        /// </summary>
        /// <param name="activity">Activity object containing the updated details of the activity</param>
        public void UpdateActivity(Activity activity)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "update Activity set Name = @Name, Points = @Points, LocationId = @LocationId where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", activity.Id);
                    cmd.Parameters.AddWithValue("@Name", activity.Name);
                    cmd.Parameters.AddWithValue("@Points", activity.Points);
                    cmd.Parameters.AddWithValue("@LocationId", activity.LocationId);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        /// <summary>
        /// Delete an activity from the database by id
        /// </summary>
        /// <param name="id">Id of the activity to be deleted</param>
        public void DeleteActivity(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "delete from Activity where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        // DataAccessLayer for Location

        /// <summary>
        /// Get all locations from the database and put them in a DataTable
        /// </summary>
        /// <returns>DataTable containing all locations</returns>
        public DataTable GetAllLocation()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Location";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }
        }

        // Method to get all members from the database
        public DataTable GetAllMembers()
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "select * from Member";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    var reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    cnn.Close();
                    return dt;
                }
            }
        }

        /// <summary>
        /// Add a location to the database with the constructor values of Location 
        /// </summary>
        /// <param name="location">Location object containing the details of the location</param>
        public void CreateLocation(Location location)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "insert into Location (Name, Address) values (@Name, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", location.Name);
                    cmd.Parameters.AddWithValue("@Address", location.Address);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        /// <summary>
        /// Update a location in the database with the constructor values of Location
        /// </summary>
        /// <param name="location">Location object containing the updated details of the location</param>
        public void UpdateLocation(Location location)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "update Location set Name = @Name, Address = @Address where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", location.Id);
                    cmd.Parameters.AddWithValue("@Name", location.Name);
                    cmd.Parameters.AddWithValue("@Address", location.Address);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        /// <summary>
        /// Delete a location from the database by id
        /// </summary>
        /// <param name="id">Id of the location to be deleted</param>
        public void DeleteLocation(int id)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "delete from Location where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

        // Method to get a trainer by credentials from the database
        public Trainer GetTrainerByCredentials(string username, string password)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                // Create the SQL query to retrieve the trainer
                var query = "SELECT Id, Name, Age, Username, Password FROM Trainer WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    // Add parameters to the SQL query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the query and read the result
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Create a new Trainer object with the data from the database
                        Trainer trainer = new Trainer(
                            Convert.ToInt32(reader["Id"]),
                            reader["Name"].ToString(),
                            Convert.ToInt32(reader["Age"]),
                            reader["Username"].ToString(),
                            reader["Password"].ToString()
                        );
                        cnn.Close();
                        return trainer;
                    }
                    else
                    {
                        cnn.Close();
                        // Return null if no trainer is found with the given credentials
                        return null;
                    }
                }
            }
        }

        // Method to get a location by id from the database
        public Location GetLocationById(int locationId)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "SELECT Id, Name, Address FROM Location WHERE Id = @LocationId";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@LocationId", locationId);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Location location = new Location(
                            Convert.ToInt32(reader["Id"]),
                            reader["Name"].ToString(),
                            reader["Address"].ToString()
                        );
                        cnn.Close();
                        return location;
                    }
                    else
                    {
                        cnn.Close();
                        return null;
                    }
                }
            }
        }

        // Method to get a member by credentials from the database
        public Member GetMemberByCredentials(string username, string password)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                // Create the SQL query to retrieve the member
                var query = "SELECT Id, Name, Age, Progress, Username, Password FROM Member WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    // Add parameters to the SQL query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    // Execute the query and read the result
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Create a new Member object with the data from the database
                        var id = Convert.ToInt32(reader["Id"]);
                        var name = reader["Name"].ToString();
                        var age = Convert.ToInt32(reader["Age"]);
                        var progress = Convert.ToInt32(reader["Progress"]);
                        Member member = new Member(id, name, age, progress, username, password);

                        cnn.Close();
                        return member;
                    }
                    else
                    {
                        cnn.Close();
                        // Return null if no member is found with the given credentials
                        return null;
                    }
                }
            }
        }
    }
}
