using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitZuyd.Forms
{
    public partial class MemberLogin : Form
    {
        public MemberLogin()
        {
            InitializeComponent();
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            // Logic for Trainer button (if needed)
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            // Logic for Member button (if needed)
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            // Logic for Password label click (if needed)
        }

        private void inpUsername_TextChanged(object sender, EventArgs e)
        {
            // Logic for Username text changed (if needed)
        }

        private void inpPassword_TextChanged(object sender, EventArgs e)
        {
            // Logic for Password text changed (if needed)
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberLanding memberLanding = new MemberLanding();
            memberLanding.Show();
        }

        private void buttonLoginMember_Click(object sender, EventArgs e)
        {
            string username = inpUsername.Text;
            string password = inpPassword.Text;

            // Call the LoginMember method and handle the result
            bool loginSuccess = Member.LoginMember(username, password);

            if (loginSuccess)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord. Probeer het opnieuw.", "Login Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
