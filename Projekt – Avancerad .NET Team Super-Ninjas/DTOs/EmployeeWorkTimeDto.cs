namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.DTOs
{
    public class EmployeeWorkTimeDto
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }

        public TimeSpan? WorkHours { get; set; }
        
    }
}
