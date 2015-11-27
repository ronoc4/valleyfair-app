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
    public partial class Main : Form
    {
        string currDateTime = DateTime.Now.ToString("hh:mm:ss tt");

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currDateTime = DateTime.Now.ToString("hh:mm:ss tt");
            this.Text = Convert.ToString(currDateTime);
        }



        


        //todo Add code

    }
}
