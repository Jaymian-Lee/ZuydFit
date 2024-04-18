using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitZuyd.Forms
{
    public partial class TrainerLocationDelete : Form
    {
        public TrainerLocationDelete()
        {
            InitializeComponent();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            int locationId = int.Parse(TextBoxId.Text);
            location.DeleteFromDatabase(locationId);
            MessageBox.Show("Location was deleted");
            TextBoxId.Clear();
           

        }

        

        private void btnClose_location_Click(object sender, EventArgs e)
        {
            TrainerLocations location = new TrainerLocations();
            location.Show();
            this.Hide();
        }
    }
}
