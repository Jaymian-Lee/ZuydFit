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
    public partial class MemberMenu : Form
    {
        public MemberMenu()
        {
            InitializeComponent();
            listViewActivities.View = View.Details;
            listViewActivities.GridLines = true;

            listViewActivities.Columns.Add("ID", 75);
            listViewActivities.Columns.Add("Name: ", 100);
            listViewActivities.Columns.Add("Points", 150);

            if (Member.ParticipatedActivities != null)
            {
                foreach (Activity activity in Member.ParticipatedActivities)
                {
                    ListViewItem listItem = new ListViewItem(activity.Id.ToString());
                    listItem.SubItems.Add(activity.Name);
                    listItem.SubItems.Add(activity.Points.ToString());
                    listItem.SubItems.Add(activity.LocationId.ToString());
                    

                    listViewActivities.Items.Add(listItem);
                }
            }
        }


        private void btnLocations_Click(object sender, EventArgs e)
        {
            MemberLocations memberLocations = new MemberLocations();
            memberLocations.Show();
            this.Hide();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            MemberActivtity memberActivtity = new MemberActivtity();
            memberActivtity.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            this.Close();
        }

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBarMember_Click(object sender, EventArgs e)
        {

        }
    }
}
