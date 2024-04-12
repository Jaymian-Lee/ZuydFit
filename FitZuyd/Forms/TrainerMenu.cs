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
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainerLocations trainerLocations = new TrainerLocations();
            trainerLocations.Show();
        }

        private void TrainerMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainerActivity trainerActivity = new TrainerActivity();
            trainerActivity.Show();
        }
    }
}
