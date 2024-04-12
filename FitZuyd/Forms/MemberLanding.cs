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
    public partial class MemberLanding : Form
    {
        public MemberLanding()
        {
            InitializeComponent();
        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            memberLogin.Show();
            this.Hide();
        }

        private void btnMemberRegister_Click(object sender, EventArgs e)
        {
            MemberRegister memberRegister = new MemberRegister();
            memberRegister.Show();
            this.Hide();
        }

        private void MemberLanding_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.Show();
        }
    }
}
