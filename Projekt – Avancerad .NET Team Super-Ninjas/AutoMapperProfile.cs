global using AutoMapper;
using Projekt___Avancerad_.NET_Team_Super_Ninjas.DTOs;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<TimeReport, TimeReportDto>();
            CreateMap<JoinedEmpProj, EmployeeProjectDto >();
            CreateMap<Employee, EmployeeProjectDto>();

        }
    }
}
