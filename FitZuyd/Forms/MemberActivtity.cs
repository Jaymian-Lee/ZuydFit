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
            Activity activity  = new Activity();

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

        private void btnLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberLocations memberLocations = new MemberLocations();
            memberLocations.Show();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberActivtity memberActivtity = new MemberActivtity();
            memberActivtity.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberMenu memberMenu = new MemberMenu();
            memberMenu.Show();
        }
    }
}
