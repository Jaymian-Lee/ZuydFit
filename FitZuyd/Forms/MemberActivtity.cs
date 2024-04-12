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
    public partial class MemberActivtity : Form
    {
        public MemberActivtity()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberMenu memberMenu = new MemberMenu();
            memberMenu.Show();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberLocations memberLocations = new MemberLocations();
            memberLocations.Show();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberActivtity memberActivtity = new MemberActivtity();
            memberActivtity.Show();
        }
    }
}
