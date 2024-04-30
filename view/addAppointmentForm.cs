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
    public partial class addAppointmentForm : Form
    {
        public Appointment returnValue = null;
        private Tuple<long, string> client;
        public addAppointmentForm(long clientID)
        {
            InitializeComponent();

            dateTimePicker1.MinDate =DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(10);

            client = new Tuple<long,string>(clientID, CurrData.GetClientName(clientID));
            clientTextBox.Text = client.Item2 + "  ["+clientID+"]";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Check if date valid not in past
            //Check client appointments no other appointment at that time or similiar
            //Set DiagResult to OK
            DateTime time = dateTimePicker1.Value;

            if (time < DateTime.Now)    //Not allowed time in the past
                return;
            if (time.Date == DateTime.Today)
                if (MessageBox.Show("This appointment time would be today, is this correct?", "Confirm Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            if (CurrData.ClientHasAppointmentOnDate(client.Item1, time.Date))
                if (MessageBox.Show("This Client already has an appointment on this date. Are you sure this is correct?", "Confirm Date", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

            returnValue = new Appointment(client.Item1,time,notesTextBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
