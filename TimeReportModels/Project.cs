using System.ComponentModel.DataAnnotations;

namespace TimeReportModels
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // public ICollection<Employee> Employees { get; set; }

    }
}