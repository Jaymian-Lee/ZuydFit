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
            listViewActivities.Columns.Add("Name", 100);
            listViewActivities.Columns.Add("Points", 150);
            listViewActivities.Columns.Add("Location", 200);

            LoadParticipatedActivities();

            progressBarMember.Maximum = 100;
            progressBarMember.Value = Member.CurrentMember?.Progress ?? 0;
        }

        // Methode om de deelgenomen activiteiten in te laden in de listView
        private void LoadParticipatedActivities()
        {
            listViewActivities.Items.Clear();

            if (Member.CurrentMember != null && Member.CurrentMember.ParticipatedActivities != null)
            {
                foreach (Activity activity in Member.CurrentMember.ParticipatedActivities)
                {
                    Location location = activity.GetLocation();  // Haal locatie op
                    ListViewItem listItem = new ListViewItem(activity.Id.ToString());
                    listItem.SubItems.Add(activity.Name);
                    listItem.SubItems.Add(activity.Points.ToString());
                    listItem.SubItems.Add(location != null ? location.Name : "Unknown Location"); // Toon locatie naam

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

        // Methode die wordt aangeroepen wanneer de knop 'Finish Activities' wordt ingedrukt
        private void btnFinishActivities_Click(object sender, EventArgs e)
        {
            if (Member.CurrentMember != null && listViewActivities.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewActivities.SelectedItems[0];
                int selectedActivityId = int.Parse(selectedItem.Text);

                Activity selectedActivity = Member.CurrentMember.ParticipatedActivities
                    .FirstOrDefault(a => a.Id == selectedActivityId);

                if (selectedActivity != null)
                {
                    Member.CurrentMember.UpdateProgress(selectedActivity.Points);
                    Member.CurrentMember.ParticipatedActivities.Remove(selectedActivity); // Verwijder alleen de geselecteerde activiteit
                    progressBarMember.Value = Member.CurrentMember.Progress;

                    LoadParticipatedActivities();  // Herlaad de activiteitenlijst

                    MessageBox.Show("Activiteit voltooid en voortgang bijgewerkt!");
                }
            }
            else
            {
                MessageBox.Show("Selecteer een activiteit om te voltooien.", "Geen activiteit geselecteerd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
