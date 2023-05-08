namespace TimeReportModels
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<TimeReport> TimeReports { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}