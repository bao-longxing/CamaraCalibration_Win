using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamaraCalibration_Win
{
    public static class SnackbarManager
    {
        private static MaterialSnackBar bar;
        private static Form form1 = null;
        public  static void Initilaze(Form form)
        {
            form1 = form;
        }
        public static void ShowMessage(string message, int time = 0)
        {
            if (time == 0)
            {
                bar = new MaterialSnackBar(message);
                bar.Show(form1);
            }
            else
            {
                bar = new MaterialSnackBar(message,time);
                bar.Show(form1);
            }
        }


    }
}
