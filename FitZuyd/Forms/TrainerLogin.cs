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
    public partial class TrainerLogin : Form
    {
        public TrainerLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainerLanding trainerLanding = new TrainerLanding();
            trainerLanding.Show();
        }

        private void btnLoginTrainer_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainerMenu trainerMenu = new TrainerMenu();
            trainerMenu.Show();
        }
    }
}
