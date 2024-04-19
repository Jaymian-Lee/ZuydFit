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
    public partial class MemberRegister : Form
    {
        public MemberRegister()
        {
            InitializeComponent();
        }

        private void inpUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterMember_Click(object sender, EventArgs e)
        {


            // Haal de waarden uit de tekstvakken
            string username = inpUsername.Text;
            string password = inpPassword.Text;
            string name = inpFullname.Text;
            int age = int.Parse(inpAge.Text); // Voeg foutafhandeling toe voor het geval de invoer geen getal is

            // Creëer een nieuw Trainer object
            Member.CreateMember(0, name, age, 0, username, password);  // Aanroepen van de statische methode CreateTrainer           
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MemberLanding memberLanding = new MemberLanding();
            memberLanding.Show();
            this.Hide();
        }
    }
}
