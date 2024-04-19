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
    public partial class TrainerActivityUpdate : Form
    {
        public TrainerActivityUpdate()
        {
            InitializeComponent();
        }

        private void btnClose_location_Click(object sender, EventArgs e)
        {
            TrainerActivity activity = new TrainerActivity();
            activity.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.Id = int.Parse(TextBoxId.Text);
            activity.Name = textBoxName.Text;
            activity.Points = int.Parse(textBoxPoints.Text);
            activity.UpdateFromDatabase();

        }
    }
}
