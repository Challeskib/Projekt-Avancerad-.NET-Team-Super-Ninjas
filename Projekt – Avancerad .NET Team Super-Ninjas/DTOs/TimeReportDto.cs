using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeReportModels.DTOs
{
    internal class TimeReportDto
    {
        public DateTime Start { get; set; }
        public TimeSpan WorkHours { get; set; }
    }
}
