﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CpuTempMonitor.Controllers
{
    class CpuTemp
    {
        public string Name { get; set; }
        public List<CpuTempSensor> Sensors { get; set; }
    }

    class CpuTempSensor
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public float? Temp { get; set; }
    }
}