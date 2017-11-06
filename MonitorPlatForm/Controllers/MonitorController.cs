using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using MonitorPlatForm.Models;

namespace MonitorPlatForm.Controllers
{
    class MonitorController
    {

        public MonitorController(IMonitorView view)
        {
            this.mView = view;
        }
            



        private MonitorPowerModel mPower;
        private IMonitorView mView;

    }
}
