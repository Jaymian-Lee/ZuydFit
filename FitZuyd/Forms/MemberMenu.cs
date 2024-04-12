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
    public partial class MemberMenu : Form
    {
        public MemberMenu()
        {
            InitializeComponent();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            MemberLocations memberLocations = new MemberLocations();
            memberLocations.Show();
            this.Hide();
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            MemberActivtity memberActivtity = new MemberActivtity();
            memberActivtity.Show();
            this.Hide();
        }
    }
}
