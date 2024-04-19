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
    public partial class TrainerMenu : Form
    {
        public TrainerMenu()
        {
            InitializeComponent();

            Member member = new Member();

            listViewMembers.View = View.Details;
            listViewMembers.GridLines = true;

            listViewMembers.Columns.Add("ID", 100);
            listViewMembers.Columns.Add("Name: ", 150);
            listViewMembers.Columns.Add("Age: ", 150);
            listViewMembers.Columns.Add("Progress: ", 200);

            foreach (DataRow row in member.GetAllMembers().Rows)
            {
                string memberId = row["ID"].ToString();
                string memberName = row["Name"].ToString();
                string memberAge = row["Age"].ToString();
                string memberProgress = row["Progress"].ToString();

                ListViewItem listItem = new ListViewItem();
                listItem.Text = memberId;
                listItem.SubItems.Add(memberName);
                listItem.SubItems.Add(memberAge);
                listItem.SubItems.Add(memberProgress);

                listViewMembers.Items.Add(listItem);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            this.Close();
        }

        private void listViewMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
