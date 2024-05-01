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
        public List<Field> returnValue = new List<Field>();

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
                //TODO move this into seperate functions for each field type
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
            bool allValid = true;

            foreach (GroupBox field in panel1.Controls.Find("fieldGroupBox", true))
            {
                //try
                //{
                    var input = field.Controls.Find("userInput", false).FirstOrDefault().Text;
                    (string temp_dataType,bool nullable) = CurrData.databaseScheme[field.Text];
                    if (!nullable && input == "") 
                    {
                        allValid = false;
                        MessageBox.Show(field.Text + " was not valid input");
                        break;
                    }
                    else //Valid input
                    {
                    //Create Field object, of correct type
                    //Add to return arr
                    //Eventually return the arr
                    try
                    {
                        Field newField;

                        switch (temp_dataType)
                        {
                            case ("NCHAR(100)"):
                                newField = new FieldShortString(field.Text, input);
                                break;
                            case ("INTEGER"):
                                newField = new FieldInteger(field.Text, input);
                                break;
                            case ("DATE"):
                                newField = new FieldDate(field.Text, input);
                                break;
                            case ("DATETIME"):
                                newField = new FieldDateTime(field.Text, input);
                                break;
                            case ("TEXT"):
                                newField = new FieldLongString(field.Text, input);
                                break;
                            case ("REAL"):
                                newField = new FieldReal(field.Text, input);
                                break;
                            default:
                                newField = new Field(field.Text, input);
                                break;
                        }

                        returnValue.Add(newField);
                    }
                    catch 
                    {
                        returnValue.Clear();
                        MessageBox.Show("Parseing of inputs faild, Please check each input value matches the type of input expected");
                    }
                    }
                //}
                //catch (Exception ex) { throw ex;}//Make write error and return to break loop and fuction
            }

            if (allValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
