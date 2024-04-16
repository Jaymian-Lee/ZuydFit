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
    public partial class TrainerLocations : Form
    {
        public TrainerLocations()
        {
            InitializeComponent();

            Location location = new Location();
            
            listViewTLocation.View = View.Details;
            listViewTLocation.GridLines = true;

            listViewTLocation.Columns.Add("ID", 100);
            listViewTLocation.Columns.Add("Name: ", 150);
            listViewTLocation.Columns.Add("Address: ", 200);

            foreach(DataRow row in location.GetAllLocations().Rows)
            {
                string locationId = row["ID"].ToString();
                string locationName = row["Name"].ToString();
                string locationAddress = row["Address"].ToString();

                ListViewItem listItem = new ListViewItem();
                listItem.Text = locationId;
                listItem.SubItems.Add(locationName);
                listItem.SubItems.Add(locationAddress);

                listViewTLocation.Items.Add(listItem);
            }
            

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
            TrainerLocationCreate locationCreate = new TrainerLocationCreate();
            locationCreate.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TrainerLocationUpdate locationUpdateDelete = new TrainerLocationUpdate();
            locationUpdateDelete.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TrainerLocationUpdate locationUpdateDelete = new TrainerLocationUpdate();
            locationUpdateDelete.Show();
            this.Hide();
        }
    }
}
