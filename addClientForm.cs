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
    public partial class addClientForm : Form
    {
        public Field[] returnValue = null;

        public addClientForm()
        {
            InitializeComponent();
            //Get db scheme
            //generate and add group boxes
            //add event handler
            //add validation function
            CreateControls();
        }

        private void CreateControls()
        {
            panel1.SuspendLayout();

            foreach (KeyValuePair<string, Tuple<string, bool>> field in CurrData.databaseScheme)
            {
                GroupBox groupBox1 = new System.Windows.Forms.GroupBox();
                TextBox textBox1 = new System.Windows.Forms.TextBox();

                groupBox1.SuspendLayout();


                groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                groupBox1.Controls.Add(textBox1);
                groupBox1.Location = new System.Drawing.Point(3, 3);
                groupBox1.Name = "fieldGroupBox";
                groupBox1.Size = new System.Drawing.Size(242, 46);
                groupBox1.TabIndex = 0;
                groupBox1.TabStop = false;
                groupBox1.Text = field.Key;


                textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                textBox1.Location = new System.Drawing.Point(7, 20);
                textBox1.Name = "userInput";
                textBox1.Size = new System.Drawing.Size(229, 20);
                textBox1.TabIndex = 0;

                groupBox1.ResumeLayout(false);
                groupBox1.PerformLayout();

                panel1.Controls.Add(groupBox1);
            }

            panel1.ResumeLayout(false);
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            //collect inputs
            //check if non optional input fields have some value
            //call client constructor
            //set diagresult to ok
            //close

            foreach (GroupBox field in panel1.Controls.Find("fieldGroupBox", true))
            { 
                
            }
        }
    }
}
