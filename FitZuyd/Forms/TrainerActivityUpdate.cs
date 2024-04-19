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

        /*private void btnClose_Click(object sender, EventArgs e)
        {
            TrainerActivity activity = new TrainerActivity();
            activity.Show();
            this.Hide();
        }*/

        /*private void btnUpdate_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            activity.Id = int.Parse(TextBoxId.Text);
            activity.Name = textBoxName.Text;
            activity.Points = int.Parse(textBoxPoints.Text);
            activity.UpdateFromDatabase();

        }*/

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Activity globalActivity = new Activity();
            Activity activity = new Activity();
            activity.Id = int.Parse(TextBoxId.Text);
            activity.Name = textBoxName.Text;
            activity.Points = int.Parse(textBoxPoints.Text);
            activity.LocationId = int.Parse(textBoxLocationId.Text);

            globalActivity.UpdateFromDatabase(activity);

            MessageBox.Show("Activity was Updated");
            textBoxName.Clear();
            textBoxPoints.Clear();
            textBoxLocationId.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TrainerActivity activity = new TrainerActivity();
            activity.Show();
            this.Hide();
        }
    }
}
