using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderServiceApp
{
    public partial class FormDisplayTime : Form
    {
        _Service service;
        string Time;
        string KindOf;

        public FormDisplayTime()
        {
            InitializeComponent();
            service = new _Service();
            dgvDisplayTime.DataSource = service.OpenFile().OrderByDescending(s => Convert.ToDateTime(s.Time)).ToList();
        }
        private void btnAddTime_Click(object sender, EventArgs e)
        {
            FormAddTime formAddOneTime = new FormAddTime();
            formAddOneTime.ShowDialog();
            dgvDisplayTime.DataSource = service.OpenFile().OrderByDescending(s => Convert.ToDateTime(s.Time)).ToList();
        }
        private void DisplayTimeScreen_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Application.ExitThread();
        }

        private void menuItemAddTime_Click(object sender, EventArgs e)
        {
            FormAddTime formAddOneTime = new FormAddTime();
            formAddOneTime.ShowDialog();
        }

        private void menuItemShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            ToolStripMenuItem menuItemShow = new ToolStripMenuItem("Show");
            ToolStripMenuItem menuItemAddTime = new ToolStripMenuItem("Add time");
            ToolStripMenuItem menuItemExit = new ToolStripMenuItem("Exit");

            menuItemShow.Click += new EventHandler(menuItemShow_Click);
            menuItemAddTime.Click += new EventHandler(menuItemAddTime_Click);
            menuItemExit.Click += new EventHandler(menuItemExit_Click);

            menuItemShow.Name = "Show";
            menuItemAddTime.Name = "Add time";
            menuItemExit.Name = "Exit";

            //add item into contextMenuStrip
            contextMenuStrip.Items.Add(menuItemShow);
            contextMenuStrip.Items.Add(menuItemAddTime);
            contextMenuStrip.Items.Add(menuItemExit);


            notifyIconRemind.ContextMenuStrip = contextMenuStrip;// add contextMenuStrip to notifyIcon1
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            List<Alarm> newList = new List<Alarm>();

            newList = service.OpenFile();

            if(Time == null)
            {
                DialogResult dialogResult = MessageBox.Show("You did not pick th time to delete. Please pick again!","Remove time",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

            //Remove alarm object from newList
            if (newList.Any(c => c.Time == Time))
            {
                Alarm arlam = newList.FirstOrDefault(c => c.Time == Time);
                DialogResult result = MessageBox.Show($"Do you wan to delete this time {Time}", "Remove time", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result.Equals(DialogResult.OK))
                {
                    newList.Remove(arlam);
                    MessageBox.Show("Deleted succesfully");
                }
            }
            //Write to Json file
            service.WriteToFile(newList);
            Time=null;
            //Reload DataGridView
            dgvDisplayTime.DataSource = service.OpenFile().OrderByDescending(s => Convert.ToDateTime(s.Time)).ToList();
        }

        private void dgvDisplayDaily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Time = dgvDisplayTime.Rows[e.RowIndex].Cells[0].Value.ToString();
                KindOf = dgvDisplayTime.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not pick in here");
            }
        }

        private void FormDisplayTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
