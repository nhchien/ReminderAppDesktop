using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderServiceApp
{
    public static class Program
    {
        static System.Threading.Timer theTimer;
        static bool serviceWasRunning = false;
        static FormDisplayTime formDisplayTime;
        static _Service service = new _Service();
        /// <summary>
        /// The main entry point for the application.
        /// STAThread for the benefit of the GUI; service will ignore it.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            if (Environment.UserInteractive)
            {
                //DisableServiceIfRunning();
                OnStart(args);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                formDisplayTime = new FormDisplayTime();
                Application.Run(formDisplayTime);
                OnStop();
                //EnableServiceIfWasRunning();
            }
            else
            {
                formDisplayTime = new FormDisplayTime();
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new ServiceReminder()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
        static public void OnStart(string[] args)
        {
            theTimer = new System.Threading.Timer(TickHandler, null, 1000, 1000);
        }
        static public void OnStop()
        {
            theTimer.Change(0, Timeout.Infinite);
            theTimer.Dispose();
        }

        //
        static public void TickHandler(object state)
        {
            _Service service = new _Service();
            List<Alarm> alarmLists = new List<Alarm>();
            alarmLists = service.OpenFile();
            var timeNow = DateTime.Now.ToString();

            if (alarmLists.Any(c => Convert.ToDateTime(c.Time).ToString() == timeNow))
            {       
                //FormDisplayTime formDisplayTime = new FormDisplayTime();
                Alarm alarm = alarmLists.FirstOrDefault(c => Convert.ToDateTime(c.Time).ToString() == timeNow);
                formDisplayTime.notifyIconRemind.BalloonTipText = alarm.Message;
                formDisplayTime.notifyIconRemind.BalloonTipTitle = "Reminder";
                formDisplayTime.notifyIconRemind.ShowBalloonTip(3000);
                //Thread.Sleep(3000);
                //formDisplayTime.notifyIconRemind.Visible = false;
                
            }
        }
        /// If the service is running, stop it.
        /// (/summary)
        private static void DisableServiceIfRunning()
        {
            try
            {
                //
                // ServiceController will throw System.InvalidOperationException if service not found.
                //
                ServiceController sc = new ServiceController("ServiceReminder");
                sc.Stop();
                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    try
                    {
                        string statusService = "State of service is " + sc.Status.ToString() + " at " + DateTime.Now.ToString();
                        service.WriteToLog(statusService);
                    }
                    catch (Exception)
                    {
                        string statusRespond = "State of service can not be stopped " + DateTime.Now.ToString();
                        service.WriteToLog(statusRespond);
                    }
                }
                serviceWasRunning = true;
                Thread.Sleep(1000);  // wait for service to stop
            }
            catch (Exception)
            {
            }
        }

        /// (summary)
        /// If the service was running, start it up again.
        /// (/summary)
        private static void EnableServiceIfWasRunning()
        {
            if (serviceWasRunning)
            {
                try
                {
                    //
                    // ServiceController will throw System.InvalidOperationException if service not found.
                    //
                    ServiceController sc = new ServiceController("ServiceReminder");
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);
                    if (sc.Status == ServiceControllerStatus.Running)
                    {
                        string statusRunning = "State of service was running at " + DateTime.Now.ToString();
                        service.WriteToLog(statusRunning);
                    }
                    else
                    {
                        string statusRespond = "Sate of service can not be started at " + DateTime.Now.ToString();
                        service.WriteToLog(statusRespond);
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
