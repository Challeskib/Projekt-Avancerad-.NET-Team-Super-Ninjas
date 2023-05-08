
using System.ComponentModel.DataAnnotations;


namespace TimeReportModels
{
    public class EmployeeProject
    {
        //[Key]
        //public int EmpProjId { get; set; }
        public int EmpId { get; set; }
        public int ProjId { get; set; }
    }
}
