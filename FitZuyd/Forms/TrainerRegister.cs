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
    public partial class TrainerRegister : Form
    {
        public TrainerRegister()
        {
            InitializeComponent();
        }

        private void btnRegisterTrainer_Click(object sender, EventArgs e)
        {
            TrainerMenu trainerMenu = new TrainerMenu();
            trainerMenu.Show();
            this.Hide();
        }
    }
}
