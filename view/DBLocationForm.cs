using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class DBLocationForm : Form
    {
        public DBLocationForm()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                locationTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //Validate textbox input
            if (!(System.IO.File.Exists(locationTextBox.Text) && locationTextBox.Text.EndsWith(".sqlite")))
                return;
            else
            {
                CurrData.SetConnenctionString(locationTextBox.Text);
                this.Close();
            }
        }
    }
}
