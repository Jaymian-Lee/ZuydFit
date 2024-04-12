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
    public partial class MemberLocations : Form
    {
        public MemberLocations()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberMenu memberMenu = new MemberMenu();
            memberMenu.Show();
        }
    }
}
