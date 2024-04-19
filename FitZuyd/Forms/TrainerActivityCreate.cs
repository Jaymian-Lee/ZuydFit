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
    public partial class TrainerActivityCreate : Form
    {
        public TrainerActivityCreate()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int points = int.Parse(textBoxLocationId.Text);
            int locationId = int.Parse(textBoxLocationId.Text);

            Activity activity = new Activity(name, points, locationId);
            activity.SaveToDatabase();

            MessageBox.Show("Activity was added");
            textBoxName.Clear();
            textBoxPoints.Clear();
            textBoxLocationId.Clear();

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            TrainerActivity location = new TrainerActivity();
            location.Show();
            this.Hide();

        }
    }
}
