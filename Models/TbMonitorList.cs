using System;
using System.Collections.Generic;

#nullable disable

namespace WebNDTIT01.Models
{
    public partial class TbMonitorList
    {
        public int IdMonitorList { get; set; }
        public string MonitorManufacturer { get; set; }
        public string MonitorModel { get; set; }
        public string MonitorSerialNo { get; set; }
        public int? MonitorAsset { get; set; }
    }
}
