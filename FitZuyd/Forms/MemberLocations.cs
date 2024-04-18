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
    public partial class MemberLocations : Form
    {
        public MemberLocations()
        {
            InitializeComponent();
            btnDetails.Click += btnDetails_Click;

            Location location = new Location();

            listViewMLocation.View = View.Details;
            listViewMLocation.GridLines = true;

            listViewMLocation.Columns.Add("ID", 100);
            listViewMLocation.Columns.Add("Name: ", 150);

            foreach (DataRow row in location.GetAllLocations().Rows)
            {
                string locationId = row["ID"].ToString();
                string locationName = row["Name"].ToString();

                ListViewItem listItem = new ListViewItem();
                listItem.Text = locationId;
                listItem.SubItems.Add(locationName);

                listViewMLocation.Items.Add(listItem);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            MemberMenu memberMenu = new MemberMenu();
            memberMenu.Show();
            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listViewMLocation.SelectedItems.Count > 0)
            {
                // Haal de geselecteerde locatie op
                ListViewItem selectedItem = listViewMLocation.SelectedItems[0];

                // Haal de adresinformatie op uit de geselecteerde locatie
                string address = selectedItem.SubItems[2].Text;

                // Toon het adres in een berichtvenster
                MessageBox.Show($"Het adres van de geselecteerde locatie is: {address}", "Locatie Adres");
            }
            else
            {
                MessageBox.Show("Selecteer een locatie om het adres te tonen.", "Geen locatie geselecteerd");
            }
        }
    }
}
