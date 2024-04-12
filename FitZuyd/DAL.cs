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
        public string conString = "Data Source=.;Initial Catalog=FitZuyd;Integrated Security=True";
        public SqlConnection cnn;
        public DAL()
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
        }

        //DataAccessLayer for Member
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

        public void AddMember(Member member)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "insert into Member (Name, Age, Progress) values (@Name, @Age, @Progress)";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", member.Name);
                    cmd.Parameters.AddWithValue("@Age", member.Age);
                    cmd.Parameters.AddWithValue("@Progress", member.Progress);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }

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

        //DataAccessLayer for Trainer
        /// <summary>
        /// Get all trainers from the database and puts them in a DataTable
        /// </summary>
        /// <returns></returns>
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
        /// <param name="trainer"></param>
        public void AddTrainer(Trainer trainer)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "insert into Trainer (Name, Age) values (@Name, @Age)";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", trainer.Name);
                    cmd.Parameters.AddWithValue("@Age", trainer.Age);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
        /// <summary>
        /// Updates a trainer in the database with the constructor values of Trainer
        /// </summary>
        /// <param name="trainer"></param>
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
        /// Deletes a trainer from the database with the given id
        /// </summary>
        /// <param name="id"></param>
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

        //DataAccessLayer for Activity
        /// <summary>
        /// Get all activities from the database and puts them in a DataTable
        /// </summary>
        /// <returns></returns>
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
        /// <param name="activity"></param>
        public void AddActivity(Activity activity)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "insert into Activity (Name, Points) values (@Name, @Points)";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", activity.Name);
                    cmd.Parameters.AddWithValue("@Description", activity.Points);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
        /// <summary>
        /// Updates an Activity in the database with the constructor values of Activity
        /// </summary>
        /// <param name="activity"></param>
        public void UpdateActivity(Activity activity)
        {
            using (SqlConnection cnn = new SqlConnection(conString))
            {
                cnn.Open();
                var query = "update Activity set Name = @Name, Points = @Points where Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Id", activity.Id);
                    cmd.Parameters.AddWithValue("@Name", activity.Name);
                    cmd.Parameters.AddWithValue("@Points", activity.Points);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
        /// <summary>
        /// Deletes an Activity from the database with the given id
        /// </summary>
        /// <param name="id"></param>
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

        //DataAccessLayer for Location
        /// <summary>
        /// Gets all locations from the database and puts them in a DataTable
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Adds a location to the database with the constructor values of Location 
        /// </summary>
        /// <param name="location"></param>
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
        /// Updates a location in the database with the constructor values of Location
        /// </summary>
        /// <param name="location"></param>
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
        /// Deletes a location from the database with the given id
        /// </summary>
        /// <param name="id"></param>
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
    }
}
