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
    public partial class MemberActivtity : Form
    {
        public MemberActivtity()
        {
            InitializeComponent();

            // Initialize an Activity object to retrieve all activities
            Activity activity = new Activity();

            // Set the ListView properties
            listViewActivities.View = View.Details;
            listViewActivities.GridLines = true;

            // Add columns to the ListView
            listViewActivities.Columns.Add("ID", 75);
            listViewActivities.Columns.Add("Name", 100);
            listViewActivities.Columns.Add("Points", 150);
            listViewActivities.Columns.Add("LocationId", 200);

            // Populate the ListView with activities from the database
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

        // Event handler for the Locations button click
        private void btnLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberLocations memberLocations = new MemberLocations();
            memberLocations.Show();
        }

        // Event handler for the Activities button click
        private void btnActivities_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberActivtity memberActivtity = new MemberActivtity();
            memberActivtity.Show();
        }

        // Event handler for the Close button click
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberMenu memberMenu = new MemberMenu();
            memberMenu.Show();
        }

        // Event handler for the Participate button click
        private void btnParticipate_Click(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count > 0)
            {
                // Get the selected activity
                ListViewItem selectedItem = listViewActivities.SelectedItems[0];
                int activityId = int.Parse(selectedItem.Text); // Ensure this is an int
                string activityName = selectedItem.SubItems[1].Text;
                int activityPoints = int.Parse(selectedItem.SubItems[2].Text); // Ensure this is an int
                int locationId = int.Parse(selectedItem.SubItems[3].Text); // Ensure this is an int

                Activity activity = new Activity(activityId, activityName, activityPoints, locationId);

                // Add the activity to the current member's list of participated activities
                Member.CurrentMember.AddActivity(activity);  // Ensure Member has a static reference to the current Member

                // Display a success message
                MessageBox.Show("Succesvol deelgenomen aan de activiteit!");

                // Hide this form and show the member menu form
                this.Hide();
                MemberMenu memberMenu = new MemberMenu();
                memberMenu.Show();
            }
            else
            {
                MessageBox.Show("Selecteer een activiteit om aan deel te nemen.");
            }
        }
    }
}