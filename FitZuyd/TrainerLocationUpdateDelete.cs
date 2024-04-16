using FitZuyd.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitZuyd
{
    public partial class TrainerLocationUpdateDelete : Form
    {
        public TrainerLocationUpdateDelete()
        {
            InitializeComponent();

        }

        private void btnClose_location_Click(object sender, EventArgs e)
        {
            TrainerLocations location = new TrainerLocations();
            location.Show();
            this.Hide();
        }
    }
}
