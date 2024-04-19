using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitZuyd.Forms
{
    public partial class TrainerLocationUpdate : Form
    {
        public TrainerLocationUpdate()
        {
            InitializeComponent();
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Id = int.Parse(TextBoxId.Text);
            location.Name = textBoxName.Text;
            location.Address = textBoxAdress.Text;
            location.UpdateFromDatabase();

        }

        private void btnClose_location_Click_1(object sender, EventArgs e)
        {
            TrainerLocations location = new TrainerLocations();
            location.Show();
            this.Hide();
        }
    }
}
