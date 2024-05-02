using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class CreateDatabaseFile : Form
    {
        public CreateDatabaseFile()
        {
            InitializeComponent();
        }

        private void AddField()
        {
            Panel tempFieldPanel = new System.Windows.Forms.Panel();
            TextBox tempfieldNameTextBox = new System.Windows.Forms.TextBox();
            ComboBox tempfieldTypeDropDownBox = new System.Windows.Forms.ComboBox();
            Label tempfieldNameLabal = new System.Windows.Forms.Label();
            Label tempfieldTypeLabel = new System.Windows.Forms.Label();
            CheckBox tempnullableCheckbox = new System.Windows.Forms.CheckBox();

            fieldListPanel.SuspendLayout();
            fieldListPanel.Controls.Add(tempFieldPanel);

            // 
            // FieldPanel
            // 
            tempFieldPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            tempFieldPanel.Controls.Add(tempnullableCheckbox);
            tempFieldPanel.Controls.Add(tempfieldTypeLabel);
            tempFieldPanel.Controls.Add(tempfieldNameLabal);
            tempFieldPanel.Controls.Add(tempfieldTypeDropDownBox);
            tempFieldPanel.Controls.Add(tempfieldNameTextBox);
            tempFieldPanel.Name = "FieldPanel";
            tempFieldPanel.Size = new System.Drawing.Size(fieldListPanel.Width, 51);
            tempFieldPanel.TabIndex = 0;
            // 
            // fieldNameTextBox
            // 
            tempfieldNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            tempfieldNameTextBox.Location = new System.Drawing.Point(3, 25);
            tempfieldNameTextBox.Name = "fieldNameTextBox";
            tempfieldNameTextBox.Size = new System.Drawing.Size(180, 20);
            tempfieldNameTextBox.TabIndex = 0;
            // 
            // fieldTypeDropDownBox
            // 
            tempfieldTypeDropDownBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            tempfieldTypeDropDownBox.FormattingEnabled = true;
            tempfieldTypeDropDownBox.Location = new System.Drawing.Point(189, 24);
            tempfieldTypeDropDownBox.Name = "fieldTypeDropDownBox";
            tempfieldTypeDropDownBox.Size = new System.Drawing.Size(180, 21);
            tempfieldTypeDropDownBox.TabIndex = 1;
            tempfieldTypeDropDownBox.DataSource = CurrData.dataTypes.Clone();
            tempfieldTypeDropDownBox.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // fieldNameLabal
            // 
            tempfieldNameLabal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            tempfieldNameLabal.AutoSize = true;
            tempfieldNameLabal.Location = new System.Drawing.Point(4, 6);
            tempfieldNameLabal.Name = "fieldNameLabal";
            tempfieldNameLabal.Size = new System.Drawing.Size(60, 13);
            tempfieldNameLabal.TabIndex = 2;
            tempfieldNameLabal.Text = "Field Name";
            // 
            // fieldTypeLabel
            // 
            tempfieldTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            tempfieldTypeLabel.AutoSize = true;
            tempfieldTypeLabel.Location = new System.Drawing.Point(186, 6);
            tempfieldTypeLabel.Name = "fieldTypeLabel";
            tempfieldTypeLabel.Size = new System.Drawing.Size(82, 13);
            tempfieldTypeLabel.TabIndex = 3;
            tempfieldTypeLabel.Text = "Field Data Type";
            // 
            // nullableCheckbox
            // 
            tempnullableCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            tempnullableCheckbox.AutoSize = true;
            tempnullableCheckbox.Location = new System.Drawing.Point(384, 25);
            tempnullableCheckbox.Name = "nullableCheckbox";
            tempnullableCheckbox.Size = new System.Drawing.Size(82, 17);
            tempnullableCheckbox.TabIndex = 5;
            tempnullableCheckbox.Text = "Is Optional?";
            tempnullableCheckbox.UseVisualStyleBackColor = true;


            fieldListPanel.ResumeLayout();
        }

        private void addFieldBtn_Click(object sender, EventArgs e)
        {
            AddField();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileLocation.Text = saveFileDialog1.FileName;
            }
        }

        private bool CreateDatabase()
        {
            if (System.IO.File.Exists(fileLocation.Text) || fileLocation.Text == "")
                return false;

            string connectionString = fileLocation.Text;

            if (System.IO.File.Exists(connectionString))
            {
                MessageBox.Show("Database file of that name already exists");
                return false;
            }
            else
            {
                string commandText =
                    "CREATE TABLE Client(" +
                    "Id INTEGER NOT NULL, " +
                    "Name NCHAR(100) NOT NULL, ";

                foreach (Panel field in fieldListPanel.Controls.Find("FieldPanel", true))
                {
                    string column = field.Controls.Find("fieldNameTextBox",true).FirstOrDefault().Text.Trim().Replace(' ','_')+" ";
                    column += field.Controls.Find("fieldTypeDropDownBox", true).FirstOrDefault().Text;

                    if (column.ToLower() == "name" || column.ToLower() == "id")
                    {
                        MessageBox.Show("Name and ID columns are created automatically, it is not necessary to add them");
                    }

                    CheckBox tempCheck = (CheckBox)field.Controls.Find("nullableCheckbox", true).FirstOrDefault();
                    if (!tempCheck.Checked)
                        column += " NOT";
                    column += " NULL,";
                    commandText += column;
                }

                commandText+= "PRIMARY KEY(\"Id\" AUTOINCREMENT));";

                try
                {
                    SQLiteConnection.CreateFile(connectionString);

                    using (SQLiteConnection con = new SQLiteConnection("Data Source = " + connectionString + "; Version = 3;"))
                    {
                        con.Open();
                        SQLiteCommand command = con.CreateCommand();
                        command.CommandText = commandText;

                        command.ExecuteNonQuery();

                        command.CommandText = "CREATE TABLE Appointment(ClientID INTEGER NOT NULL," +
                            "                                           Time DATETIME NOT NULL," +
                            "                                           Notes TEXT NULL," +
                            "                                           PRIMARY KEY(ClientID,Time)," +
                            "                                           FOREIGN KEY(ClientID) REFERENCES Client(Id))";

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return true;
            }
        }

        private void createDBfileBtn_Click(object sender, EventArgs e)
        {
            if (CreateDatabase())
            {
                CurrData.SetConnenctionString(fileLocation.Text);
                CurrData.LoadLocalDatabase();
            }
            else
            {
                MessageBox.Show("Database creation failed, database likely already exists");
                return;
            }
            this.Close();
        }
    }


}
