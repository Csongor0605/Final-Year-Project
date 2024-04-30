using Final_Year_Project.model;
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

        private void DisplayAppointment(Appointment appointment)
        {
            detailDisplayPanel.Controls.Clear();


            System.Windows.Forms.GroupBox clientNameGroupBox;
            System.Windows.Forms.TextBox clientNameTextBox;
            System.Windows.Forms.GroupBox timePickerGroupBox;
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.Windows.Forms.Button changeTimeBtn;
            System.Windows.Forms.GroupBox notesGroupBox;
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.Button saveChangesBtn;
            System.Windows.Forms.Button deleteBtn;

            clientNameGroupBox = new System.Windows.Forms.GroupBox();
            clientNameTextBox = new System.Windows.Forms.TextBox();
            timePickerGroupBox = new System.Windows.Forms.GroupBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            notesGroupBox = new System.Windows.Forms.GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            changeTimeBtn = new System.Windows.Forms.Button();
            saveChangesBtn = new System.Windows.Forms.Button();
            deleteBtn = new System.Windows.Forms.Button();


            timePickerGroupBox.SuspendLayout();
            notesGroupBox.SuspendLayout();
            detailDisplayPanel.SuspendLayout();
            clientNameGroupBox.SuspendLayout();

            detailDisplayPanel.Controls.Add(clientNameGroupBox);
            detailDisplayPanel.Controls.Add(timePickerGroupBox);
            detailDisplayPanel.Controls.Add(notesGroupBox);
            detailDisplayPanel.Controls.Add(saveChangesBtn);
            detailDisplayPanel.Controls.Add(deleteBtn);

            // 
            // clientNameGroupBox
            // 
            clientNameGroupBox.Controls.Add(clientNameTextBox);
            clientNameGroupBox.Location = new System.Drawing.Point(2, 2);
            clientNameGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            clientNameGroupBox.Name = "clientNameGroupBox";
            clientNameGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            clientNameGroupBox.Size = new System.Drawing.Size(310, 52);
            clientNameGroupBox.TabIndex = 0;
            clientNameGroupBox.TabStop = false;
            clientNameGroupBox.Text = "Client Name";
            clientNameGroupBox.Enter += new System.EventHandler(groupBox1_Enter);
            // 
            // clientNameTextBox
            // 
            clientNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            clientNameTextBox.Location = new System.Drawing.Point(4, 17);
            clientNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            clientNameTextBox.Name = "clientNameTextBox";
            clientNameTextBox.ReadOnly = true;
            clientNameTextBox.Size = new System.Drawing.Size(302, 20);
            clientNameTextBox.TabIndex = 0;

            Tuple<long, string> client = new Tuple<long, string>(appointment.ClientID, CurrData.GetClientName(appointment.ClientID));
            clientNameTextBox.Text = client.Item2 + "  [" + client.Item1.ToString() + "]";

            // 
            // timePickerGroupBox
            // 
            timePickerGroupBox.Controls.Add(changeTimeBtn);
            timePickerGroupBox.Controls.Add(dateTimePicker1);
            timePickerGroupBox.Location = new System.Drawing.Point(2, 58);
            timePickerGroupBox.Margin = new System.Windows.Forms.Padding(2);
            timePickerGroupBox.Name = "timePickerGroupBox";
            timePickerGroupBox.Padding = new System.Windows.Forms.Padding(2);
            timePickerGroupBox.Size = new System.Drawing.Size(402, 52);
            timePickerGroupBox.TabIndex = 1;
            timePickerGroupBox.TabStop = false;
            timePickerGroupBox.Text = "Appointment Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dateTimePicker1.CustomFormat = "dd/MM/yy HH:mm";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = appointment.Time;
            // 
            // notesGroupBox
            // 
            notesGroupBox.Controls.Add(textBox1);
            notesGroupBox.Location = new System.Drawing.Point(3, 115);
            notesGroupBox.Name = "notesGroupBox";
            notesGroupBox.Size = new System.Drawing.Size(546, 244);
            notesGroupBox.TabIndex = 2;
            notesGroupBox.TabStop = false;
            notesGroupBox.Text = "Additional Notes";
            // 
            // textBox1
            // 
            textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            textBox1.Location = new System.Drawing.Point(3, 20);
            textBox1.Multiline = true;
            textBox1.Name = "notesTextBox";
            textBox1.Size = new System.Drawing.Size(537, 218);
            textBox1.TabIndex = 0;
            textBox1.Text = appointment.Notes;
            // 
            // changeTimeBtn
            // 
            changeTimeBtn.Location = new System.Drawing.Point(312, 17);
            changeTimeBtn.Name = "changeTimeBtn";
            changeTimeBtn.Size = new System.Drawing.Size(84, 29);
            changeTimeBtn.TabIndex = 1;
            changeTimeBtn.Text = "Change";
            changeTimeBtn.UseVisualStyleBackColor = true;
            // 
            // saveChangesBtn
            // 
            saveChangesBtn.Location = new System.Drawing.Point(3, 365);
            saveChangesBtn.Name = "saveChangesBtn";
            saveChangesBtn.Size = new System.Drawing.Size(170, 23);
            saveChangesBtn.TabIndex = 3;
            saveChangesBtn.Text = "Save Changes";
            saveChangesBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new System.Drawing.Point(179, 365);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(61, 23);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;


            timePickerGroupBox.ResumeLayout(false);
            notesGroupBox.ResumeLayout(false);
            notesGroupBox.PerformLayout();
            clientNameGroupBox.ResumeLayout(false);
            clientNameGroupBox.PerformLayout();
            detailDisplayPanel.ResumeLayout(false);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ribbonButton1_DoubleClick(object sender, EventArgs e)
        {
            DisplayAppointment(new Appointment(-1, DateTime.Now.AddMinutes(3600), "This is the test button, this should not be enabled unless testing"));
        }
    }
}
