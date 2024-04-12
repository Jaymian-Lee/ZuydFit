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
    public partial class TrainerActivity : Form
    {
        public TrainerActivity()
        {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
     
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
    }
}
