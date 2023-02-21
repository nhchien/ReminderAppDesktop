using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderServiceApp
{
    public partial class FormAddTime : Form
    {
        
        public FormAddTime()
        {
            InitializeComponent();
            //PickType();
            cbTypes.DataSource = PickType();
            dateTimePicker.Value = DateTime.Now;

        }
        public List<string> PickType()
        {
            List<string> listTypes = new List<string>
            {
                "Daily",
                "Once"
            };
            return listTypes;
        }
        private void btnConfirmAddOneTime_Click(object sender, EventArgs e)
        {
            AddTime();
        }

        private void FormAddTime_Enter(object sender, EventArgs e)
        {
            AddTime();
        }

        public void AddTime()
        {
            _Service service = new _Service();
            Alarm Alarm = new Alarm();
            List<Alarm> listAlarm = service.OpenFile();

            if ((string)cbTypes.SelectedItem == "Daily")
            {
                Alarm.Time = dateTimePicker.Value.ToString("HH:mm tt");
                Alarm.Type = "Daily";
                if (txtMessages.Text == "")
                {
                    Alarm.Message = "No message";
                }
                else
                {
                    Alarm.Message = txtMessages.Text;
                }
                if (listAlarm.Select(c => c.Time).Contains(Alarm.Time))
                {
                    MessageBox.Show("The time already exists. Please pick another time!");
                }
                else
                {
                    listAlarm.Add(Alarm);
                    MessageBox.Show("Add time successfully");
                }
            }
            else if ((string)cbTypes.SelectedItem == "Once")
            {
                Alarm.Time = dateTimePicker.Value.ToString("MM/dd/yyyy HH:mm tt");
                Alarm.Type = "Once";
                if (txtMessages.Text == "")
                {
                    Alarm.Message = "No message";
                }
                else
                {
                    Alarm.Message = txtMessages.Text;
                }
                if (listAlarm.Select(c => c.Time).Contains(Alarm.Time))
                {
                    MessageBox.Show("The time already exists. Please pick another time!");
                }
                else
                {
                    listAlarm.Add(Alarm);
                    MessageBox.Show("Add time successfully");
                }
            }

            service.WriteToFile(listAlarm);

            this.Close();
        }
    }
}
