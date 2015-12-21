using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ThatsAllFolks
{
    public partial class ThatsAllFolksService : ServiceBase
    {
        public ThatsAllFolksService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            eventLogging.WriteEntry("ThatsAllFolkes started");
            usageTimer.Elapsed += new System.Timers.ElapsedEventHandler(userSessionCheck);
        }

        private void userSessionCheck(object sender, ElapsedEventArgs e)
        {
            eventLogging.WriteEntry("ThatsAllFolkes timer triggered");
        }

        protected override void OnStop()
        {
            eventLogging.WriteEntry("ThatsAllFolkes stopped");
        }

        protected override void OnShutdown()
        {
            base.OnShutdown();
        }

        protected override void OnSessionChange(SessionChangeDescription changeDescription)
        {
            base.OnSessionChange(changeDescription);
        }
    }
}
