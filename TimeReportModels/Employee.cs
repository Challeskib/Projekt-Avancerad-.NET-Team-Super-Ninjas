﻿using System.ComponentModel.DataAnnotations;

namespace TimeReportModels
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<TimeReport> TimeReports { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}