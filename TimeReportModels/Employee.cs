using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TimeReportModels
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        [JsonIgnore]
        public ICollection<TimeReport>? TimeReports { get; set; }
        //public ICollection<Project> Projects { get; set; }
    }
}