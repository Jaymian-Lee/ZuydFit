using FitZuyd.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitZuyd
{
    public static class Program
    {
        public static DAL dAL = new DAL();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Landing ());
=======
            Application.Run(new Landing());
>>>>>>> e239ee287ce2435f78d8e0aa3f0a677b67e516f8
        }
    }
}
