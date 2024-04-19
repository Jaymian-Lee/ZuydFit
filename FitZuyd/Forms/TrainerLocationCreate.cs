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
    public partial class TrainerLocationCreate : Form
    {
        public TrainerLocationCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string adress = textBoxAdress.Text;

            Location location = new Location(name, adress);
            location.SaveToDatabase();

            MessageBox.Show("Location was added");
            textBoxName.Clear();
            textBoxAdress.Clear();


        }

        private void btnClose_location_Click(object sender, EventArgs e)
        {
            TrainerLocations location = new TrainerLocations();
            location.Show();
            this.Hide();
        }

    }
}
