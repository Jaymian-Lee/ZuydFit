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
    public partial class TrainerActivityDelete : Form
    {
        public TrainerActivityDelete()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            int activityId = int.Parse(TextBoxId.Text);
            activity.DeleteFromDatabase(activityId);
            MessageBox.Show("Location was deleted");
            TextBoxId.Clear();


        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            TrainerActivity activity = new TrainerActivity();
            activity.Show();
            this.Hide();
        }
    }
}
