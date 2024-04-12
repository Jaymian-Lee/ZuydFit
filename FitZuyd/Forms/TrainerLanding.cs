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
    public partial class TrainerLanding : Form
    {
        public TrainerLanding()
        {
            InitializeComponent();
        }

        private void btnTrainerLogin_Click(object sender, EventArgs e)
        {
            TrainerLogin trainerLogin = new TrainerLogin();
            trainerLogin.Show();
            this.Hide();
        }

        private void btnTrainerRegister_Click(object sender, EventArgs e)
        {
            TrainerRegister trainerRegister = new TrainerRegister();
            trainerRegister.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Go back to previous page
            Landing landing = new Landing();
            landing.Show();
            this.Hide();

        }
    }
}
