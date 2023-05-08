using System.ComponentModel.DataAnnotations;

namespace TimeReportModels
{
    public class TimeReport
    {
        [Key]
        public int TRId { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        [Range(typeof(DateTime), "1/1/2023", "1/1/2030", ErrorMessage = "Date is outside of accepted range")]
        public DateTime Start { get; set; }

        [Range(typeof(DateTime), "1/1/2023", "1/1/2030", ErrorMessage = "Date is outside of accepted range")]
        public DateTime End { get; set; }
        public TimeSpan WorkHours { get; set; }

        public TimeReport(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
            WorkHours = End.Subtract(Start);
        }
    }
}