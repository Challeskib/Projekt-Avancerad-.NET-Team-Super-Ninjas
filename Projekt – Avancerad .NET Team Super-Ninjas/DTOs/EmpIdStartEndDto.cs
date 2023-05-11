using System.ComponentModel.DataAnnotations;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.DTOs
{
    public class EmpIdStartEndDto
    {
        public int EmployeeId { get; set; }
        
        [Range(typeof(DateTime), "1/1/2023", "1/1/2030"
        , ErrorMessage = "Date is outside of accepted range")]
        public DateTime Start { get; set; }


        [Range(typeof(DateTime), "1/1/2023", "1/1/2030"
        , ErrorMessage = "Date is outside of accepted range")]
        public DateTime End { get; set; }

    }
}
