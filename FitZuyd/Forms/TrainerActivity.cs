using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitZuyd.Forms
{
    public partial class TrainerActivity : Form
    {
        public TrainerActivity()
        {
            InitializeComponent();
            Activity activity = new Activity();

            listViewActivities.View = View.Details;
            listViewActivities.GridLines = true;

            listViewActivities.Columns.Add("ID", 75);
            listViewActivities.Columns.Add("Name: ", 100);
            listViewActivities.Columns.Add("Points", 150);
            listViewActivities.Columns.Add("LocationId: ", 200);

            foreach (DataRow row in activity.GetAllActivities().Rows)
            {
                string activityId = row["ID"].ToString();
                string activityName = row["Name"].ToString();
                string activityPoints = row["Points"].ToString();
                string locationId = row["LocationId"].ToString();

                ListViewItem listItem = new ListViewItem();
                listItem.Text = activityId;
                listItem.SubItems.Add(activityName);
                listItem.SubItems.Add(activityPoints);
                listItem.SubItems.Add(locationId);

                listViewActivities.Items.Add(listItem);
            }
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
     
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            TrainerLocations trainerLocations = new TrainerLocations();
            trainerLocations.Show();
            this.Hide();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            TrainerActivity trainerActivity = new TrainerActivity();
            trainerActivity.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TrainerMenu trainerMenu = new TrainerMenu();
            trainerMenu.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TrainerActivityCreate trainerActivityCreate = new TrainerActivityCreate();
            trainerActivityCreate.Show();
            this.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            TrainerActivityUpdate trainerActivityUpdate = new TrainerActivityUpdate();
            trainerActivityUpdate.Show();
            this.Hide();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            TrainerActivityDelete trainerActivityDelete = new TrainerActivityDelete();
            trainerActivityDelete.Show();
            this.Hide();
        }
    }
}
