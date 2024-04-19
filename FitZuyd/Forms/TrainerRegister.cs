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
        DAL DAL = new DAL();
        public TrainerRegister()
        {
            InitializeComponent();
        }

        private void btnRegisterTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                // Haal de waarden uit de tekstvakken
                string username = inpUsername.Text;
                string password = inpPassword.Text;
                string name = inpFullname.Text;
                int age = int.Parse(inpAge.Text); // Probeer de leeftijd te converteren

                // Aanmaken van de trainer en toevoegen aan de database
                Trainer.CreateTrainer(0, name, age, username, password);  // Aanroepen van de statische methode CreateTrainer
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Voer een geldig getal in voor de leeftijd.");
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            TrainerLogin trainerLogin = new TrainerLogin();
            trainerLogin.Show();
            this.Hide();
        }
    }
}
