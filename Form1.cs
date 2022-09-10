using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Test_1
{
    public partial class Super_Futur_Machine : Form
    {
        public Super_Futur_Machine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nice To meet you";

        }

        private void btn_Hello_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonhello_Click(object sender, EventArgs e)
        {
            label1.Text = "You just clicked text!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You Clicked The Other Button!";


        }
    }
}
