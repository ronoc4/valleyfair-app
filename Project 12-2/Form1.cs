using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            frmOptions frm = new frmOptions();
            frm.ShowDialog();

            DateTime currentTime = DateTime.Now;

            //need to add in a timer in order to refresh the text property of the thing

            System.Timers.Timer RefreshTimer = new System.Timers.Timer();
            //RefreshTimer.Interval = 1000;
            RefreshTimer.Enabled = true;




            string ShortTime = currentTime.ToLongTimeString();
            this.Text = ShortTime;
            
            

        }















        private void LoadOptions(object sender, EventArgs e)
    {
        
    }


    }
}
