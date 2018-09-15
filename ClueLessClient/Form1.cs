using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClueLessClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connectionStringTextBox.Text = Properties.Settings.Default.SeverURL;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }

        //private void connectionStringTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    Size size = TextRenderer.MeasureText(connectionStringTextBox.Text, connectionStringTextBox.Font);
        //    connectionStringTextBox.Width = size.Width;
        //    connectionStringTextBox.Height = size.Height;
        //}
    }
}
