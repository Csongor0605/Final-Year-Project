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
                GroupBox groupBox1 = new System.Windows.Forms.GroupBox();

                if (field.Key == "Id")
                {
                    
                }
                else if (field.Value.Item1 == "DATE" || field.Value.Item1 == "DATETIME")
                {
                    //Show datepicker
                    GroupBox tempFieldBox = new System.Windows.Forms.GroupBox();
                    tempFieldBox.SuspendLayout();

                    DateTimePicker tempFieldNumericUpDown = new System.Windows.Forms.DateTimePicker();

                    tempFieldBox.Controls.Add(tempFieldNumericUpDown);
                    tempFieldBox.Location = new System.Drawing.Point(0, 0);
                    tempFieldBox.Name = field.Key + "box";
                    tempFieldBox.Size = new System.Drawing.Size(379, 52); //Make auto size to parent width and child height
                    tempFieldBox.TabIndex = 0;
                    tempFieldBox.TabStop = false;
                    tempFieldBox.Text = field.Key + " (" + field.Value.Item1 + ")";

                    tempFieldNumericUpDown.Location = new System.Drawing.Point(7, 20);
                    tempFieldNumericUpDown.Name = field.Key + "textbox";  //Called textbox for stupid me reasons
                    tempFieldNumericUpDown.Size = new System.Drawing.Size(366, 20);
                    if(field.Value.Item2)
                        tempFieldNumericUpDown.ShowCheckBox = true;
                    if (field.Value.Item1 == "DATE")
                    {
                        tempFieldNumericUpDown.CustomFormat = "dd MMMM  yyyy";
                        tempFieldNumericUpDown.Format = DateTimePickerFormat.Custom;
                    }
                    else
                    {
                        tempFieldNumericUpDown.CustomFormat = "HH:mm dd/MM/yyyy";
                        tempFieldNumericUpDown.Format = DateTimePickerFormat.Custom;
                    }

                    tempFieldBox.ResumeLayout(false);
                    tempFieldBox.PerformLayout();
                    panel1.Controls.Add(tempFieldBox);
                }
                else if (field.Value.Item1 == "INTEGER" || field.Value.Item1 == "REAL")
                {
                    //show numeric selector
                    GroupBox tempFieldBox = new System.Windows.Forms.GroupBox();
                    tempFieldBox.SuspendLayout();
                    NumericUpDown tempFieldNumericUpDown = new System.Windows.Forms.NumericUpDown();

                    tempFieldBox.Controls.Add(tempFieldNumericUpDown);
                    tempFieldBox.Name = field.Key + "box";
                    tempFieldBox.Size = new System.Drawing.Size(242, 46);
                    tempFieldBox.TabIndex = 0;
                    tempFieldBox.TabStop = false;
                    tempFieldBox.Text = field.Key + " (" + field.Value.Item1 + ")";

                    tempFieldNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                    tempFieldNumericUpDown.Location = new System.Drawing.Point(7, 20);
                    tempFieldNumericUpDown.Name = "userInput";
                    tempFieldNumericUpDown.Size = new System.Drawing.Size(229, 20);
                    if (field.Value.Item1 != "INTEGER")
                    {
                        tempFieldNumericUpDown.DecimalPlaces = 3;

                    }
                    tempFieldBox.ResumeLayout(false);
                    tempFieldBox.PerformLayout();
                    panel1.Controls.Add(tempFieldBox);
                }
                else
                {
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
                    groupBox1.Text = field.Key + " (" + field.Value.Item1 + ")";


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
                    string fieldText = field.Text;
                    string fieldName = fieldText.Substring(0, fieldText.LastIndexOf('(') -1);
                    if (fieldName.EndsWith("(NCHA"))
                        fieldName = fieldText.Substring(0,fieldText.Length-13);   //Stupid workaround for stupid problem, fieldtype contains brackets which also get cut off
                    (string temp_dataType,bool nullable) = CurrData.databaseScheme[fieldName];
                Control inputControl = field.Controls.Find("userInput", false).FirstOrDefault();
                string input;
                switch (temp_dataType)
                {
                    case "DATE": case "DATETIME":
                        DateTimePicker temp_inputControl = (DateTimePicker)inputControl;
                        input = temp_inputControl.Value.ToString("yyyy-MM-dd HH:mm");
                        break;
                    case "INTEGER": case "REAL":
                        NumericUpDown temp_inputControl2 = (NumericUpDown)inputControl;
                        input = temp_inputControl2.Value.ToString();
                        break;
                    default:
                        input = inputControl.Text;
                        break;
                }
                if (!nullable && input == "") 
                    {
                        allValid = false;
                        MessageBox.Show(field.Text + " was not valid input");
                        returnValue.Clear();
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
                                newField = new FieldShortString(fieldName, input);
                                break;
                            case ("INTEGER"):
                                newField = new FieldInteger(fieldName, input);
                                break;
                            case ("DATE"):
                                newField = new FieldDate(fieldName, input);
                                break;
                            case ("DATETIME"):
                                newField = new FieldDateTime(fieldName, input);
                                break;
                            case ("TEXT"):
                                newField = new FieldLongString(fieldName, input);
                                break;
                            case ("REAL"):
                                newField = new FieldReal(fieldName, input);
                                break;
                            default:
                                newField = new Field(fieldName, input);
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
