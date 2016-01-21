﻿using Stylet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncTrayzor.Pages.BarAlerts
{
    public class PausedDevicesFromMeteringViewModel : Screen, IBarAlert
    {
        public AlertSeverity Severity => AlertSeverity.Info;

        public BindableCollection<string> PausedDeviceNames { get; } = new BindableCollection<string>();

        public PausedDevicesFromMeteringViewModel(IEnumerable<string> pausedDeviceNames)
        {
            this.PausedDeviceNames.AddRange(pausedDeviceNames);
        }
    }
}
