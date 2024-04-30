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
        private long displayedID = 0; //Set to 0 when not displaying client details, long because of exception thrown

        public Form1()
        {
            InitializeComponent();
            //CurrData.LoadLocalDatabase();
            appointmentListBox.DisplayMember = "DisplayFormat";
            setAppointmentListSource();
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
                if (field.fieldName == "Id")
                    displayedID = (long)field.GetData();
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

            GroupBox appointmentsGroupBox = new GroupBox();
            Button addAppBtn = new Button();
            ListBox clientAppointmentListBox = new ListBox();
            appointmentsGroupBox.SuspendLayout();
            // 
            // appointmentsGroupBox
            // 
            appointmentsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            appointmentsGroupBox.Controls.Add(addAppBtn);
            appointmentsGroupBox.Controls.Add(clientAppointmentListBox);
            appointmentsGroupBox.Location = new System.Drawing.Point(4, nextHeight);
            appointmentsGroupBox.Name = "appointmentsGroupBox";
            appointmentsGroupBox.Size = new System.Drawing.Size(741, 275);
            appointmentsGroupBox.TabIndex = 0;
            appointmentsGroupBox.TabStop = false;
            appointmentsGroupBox.Text = "Appointments";
            // 
            // clientAppointmentListBox
            // 
            clientAppointmentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            clientAppointmentListBox.FormattingEnabled = true;
            clientAppointmentListBox.ItemHeight = 16;
            clientAppointmentListBox.Location = new System.Drawing.Point(7, 28);
            clientAppointmentListBox.Name = "clientAppointmentListBox";
            clientAppointmentListBox.Size = new System.Drawing.Size(728, 180);
            clientAppointmentListBox.TabIndex = 0;
            clientAppointmentListBox.DataSource = CurrData.GetAppointmentsByClientID(displayedID);
            // 
            // addAppBtn
            // 
            addAppBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            addAppBtn.Location = new System.Drawing.Point(7, 215);
            addAppBtn.Name = "addAppBtn";
            addAppBtn.Size = new System.Drawing.Size(728, 54);
            addAppBtn.TabIndex = 1;
            addAppBtn.Text = "Add Appointment";
            addAppBtn.UseVisualStyleBackColor = true;
            addAppBtn.Click += addAppBtn_Click;
;

            appointmentsGroupBox.ResumeLayout(false);
            detailDisplayPanel.Controls.Add(appointmentsGroupBox);
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

            var result = new addClientForm();
            result.ShowDialog();
            if (result.DialogResult == DialogResult.OK)
            {
                //try
                //{
                    CurrData.CreateNewClient(result.returnValue.ToArray());
                //}
                //catch 
                //{
                //    MessageBox.Show("Returned client data could not be parsed by constructor, please check all inputs");
                //}
            }
            //CurrData.CreateNewClient(null);
            //Add seperate form to add fields
            //listBox1.SetSelected(CurrData.clientData.Count - 1, true);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CurrData.SaveLocalDatabase();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            ClearFieldDisplay();
            CurrData.LoadLocalDatabase();
            listBox1.DataSource = CurrData.clientData;
            listBox1.DisplayMember = "displayName";
        }

        private void FieldDataChanged(object sender, EventArgs e)
        {
            string tempFieldName = ((TextBox)sender).Parent.Text;
            string data = ((TextBox)sender).Text;
            int id; //Get id from somewhere else otherwise this will break when id hidden as it should be, use listBox
            int.TryParse(detailDisplayPanel.Controls["Idbox"].Controls["Idtextbox"].Text,out id);
            CurrData.UpdateField(id,tempFieldName,data);
        }

        private void createDB_Btn_Click(object sender, EventArgs e)
        {
            //CurrData.CreateDatabase();
            CreateDatabaseFile createDBform = new CreateDatabaseFile();
            createDBform.ShowDialog();
        }

        private void selectDBLocationBtn_Click(object sender, EventArgs e)
        {
            DBLocationForm locationForm = new DBLocationForm();
            if(locationForm.ShowDialog() == DialogResult.OK)
                CurrData.LoadLocalDatabase();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            setAppointmentListSource();
        }

        private void setAppointmentListSource()
        {
            appointmentListBox.DataSource = CurrData.GetAppointmentsByDate(monthCalendar1.SelectionStart);
        }

        private void addAppBtn_Click(object sender, EventArgs e)
        {
            addAppointmentForm addAppForm = new addAppointmentForm(displayedID);
            if (addAppForm.ShowDialog() == DialogResult.OK)
                CurrData.SaveAppointment(addAppForm.returnValue);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
