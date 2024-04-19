using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private void btnParticipate_Click(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count > 0)
            {
                // Haal de geselecteerde activiteit op
                ListViewItem selectedItem = listViewActivities.SelectedItems[0];
                int activityId = int.Parse(selectedItem.Text);

                // Voeg de activiteit toe aan de lijst van deelgenomen activiteiten van de huidige gebruiker
                Member.CurrentUser.ParticipatedActivities.Add(new Activity(activityId));

                // Geef een melding van succesvolle deelname
                MessageBox.Show("Succesvol deelgenomen aan de activiteit!");

                // Verberg dit scherm en toon het vorige scherm
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
