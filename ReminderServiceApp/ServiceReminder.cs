using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ReminderServiceApp
{
    public partial class ServiceReminder : ServiceBase
    {
        public ServiceReminder()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Program.OnStart(args);
        }

        protected override void OnStop()
        {
            Program.OnStop();
        }
    }
}
