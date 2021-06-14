using System;
using System.Collections.Generic;

#nullable disable

namespace WorkerServiceDemoProject.Models
{
    public partial class GoogleCheck
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string LogMessages { get; set; }
        public string LogLevel { get; set; }
    }
}
