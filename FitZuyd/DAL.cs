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
    }
}
