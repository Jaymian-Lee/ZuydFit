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
         try
            {
                // Haal de waarden uit de tekstvakken
                string username = inpUsername.Text;
                string password = inpPassword.Text;

                // Aanmaken van de trainer en toevoegen aan de database
                Trainer.LoginTrainer(username, password);  // Aanroepen van de statische methode CreateTrainer
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message);
            }
        }


        private void inpUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
