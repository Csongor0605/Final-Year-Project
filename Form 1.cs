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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrData.LoadLocalDatabase();
            listBox1.DataSource = CurrData.clientData;
            listBox1.DisplayMember = "displayName";
        }

        private void DisplayFields(Field[] fields)
        {
            detailDisplayPanel.Controls.Clear();
            //Create field boxes
            //Set name and data text in field boxes
            int nextHeight = 0;
            int spacing = 10;
            foreach (Field field in fields)
            {
                GroupBox tempFieldBox = new System.Windows.Forms.GroupBox();
                TextBox tempFieldTextBox = new System.Windows.Forms.TextBox();

                tempFieldBox.Controls.Add(tempFieldTextBox);
                tempFieldBox.Location = new System.Drawing.Point(0, nextHeight);
                tempFieldBox.Name = field.fieldName + "box";
                tempFieldBox.Size = new System.Drawing.Size(379, 52); //Make auto size to parent width and child height
                tempFieldBox.TabIndex = 0;
                tempFieldBox.TabStop = false;
                tempFieldBox.Text = field.fieldName;
                nextHeight += tempFieldBox.Size.Height + spacing;

                tempFieldTextBox.Location = new System.Drawing.Point(7, 20);
                tempFieldTextBox.Name = field.fieldName + "textbox";
                tempFieldTextBox.Size = new System.Drawing.Size(366, 20);
                tempFieldTextBox.Text = field.GetDataAsString();
                tempFieldTextBox.TextChanged += new EventHandler(FieldDataChanged);

                detailDisplayPanel.Controls.Add(tempFieldBox);
            }
        }

        public void ClearFieldDisplay()
        {
            listBox1.SelectedIndex = -1;
            detailDisplayPanel.Controls.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < CurrData.clientData.Count)
                DisplayFields(CurrData.clientData[listBox1.SelectedIndex].GetAllFields());
            //CurrData.ChangeSelected(listBox1.SelectedIndex);
        }

        private void addClientBtn_DoubleClick(object sender, EventArgs e)
        {
            CurrData.CreateNewClient(null);
            //Add seperate form to add fields
            listBox1.SetSelected(CurrData.clientData.Count - 1, true);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CurrData.SaveLocalDatabase();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            ClearFieldDisplay();
            CurrData.LoadLocalDatabase();
        }

        private void FieldDataChanged(object sender, EventArgs e)
        {
            string tempFieldName = ((TextBox)sender).Parent.Text;
            string data = ((TextBox)sender).Text;
            int id;
            int.TryParse(detailDisplayPanel.Controls["Idbox"].Controls["Idtextbox"].Text,out id);
            CurrData.UpdateField(id,tempFieldName,data);
            //get sender.parent.name for field name
            //get client ID
            //validate
            //tell CurrDatas update client(clientID).field with new info
        }

        private void createDB_Btn_Click(object sender, EventArgs e)
        {
            //CurrData.CreateDatabase();
            CreateDatabaseFile createDBform = new CreateDatabaseFile();
            createDBform.ShowDialog();
        }
    }
}
