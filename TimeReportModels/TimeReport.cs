namespace TimeReportModels
{
    public class TimeReport
    {
        public int TRId { get; set; }
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
        public DateOnly Date { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan WorkHours { get; set; }

        public TimeReport()
        {
            WorkHours = End - Start;
        }
    }
}