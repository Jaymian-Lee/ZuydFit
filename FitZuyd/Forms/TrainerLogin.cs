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
            Landing landing = new Landing();
            landing.Show();
            this.Hide();
        }

        private void btnLoginTrainer_Click(object sender, EventArgs e)
        {
            TrainerMenu trainerMenu = new TrainerMenu();
            trainerMenu.Show();
            this.Hide();
        }
    }
}
