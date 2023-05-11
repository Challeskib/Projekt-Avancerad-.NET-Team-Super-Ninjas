using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.DTOs
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public ICollection<TimeReportDto> TimeReports { get; set; }
    }
}
