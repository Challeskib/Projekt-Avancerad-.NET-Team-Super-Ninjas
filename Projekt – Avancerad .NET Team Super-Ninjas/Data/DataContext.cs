global using Microsoft.EntityFrameworkCore;
global using TimeReportModels;

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeReport> TimeReports { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 1, Name = "Kalle Gustavsson", Email = "Kalle@företaget.com" },
                new Employee { EmpId = 2, Name = "Sara Andersson", Email = "Sara@företaget.com" },
                new Employee { EmpId = 3, Name = "Johan Svensson", Email = "Johan@företaget.com" },
                new Employee { EmpId = 4, Name = "Lisa Lindström", Email = "Lisa@företaget.com" },
                new Employee { EmpId = 5, Name = "Anders Nilsson", Email = "Anders@företaget.com" },
                new Employee { EmpId = 6, Name = "Emma Bergström", Email = "Emma@företaget.com" },
                new Employee { EmpId = 7, Name = "Peter Persson", Email = "Peter@företaget.com" },
                new Employee { EmpId = 8, Name = "Maria Karlsson", Email = "Maria@företaget.com" },
                new Employee { EmpId = 9, Name = "Erik Johansson", Email = "Erik@företaget.com" },
                new Employee { EmpId = 10, Name = "Anna Ahlström", Email = "Anna@företaget.com" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project { ProjId = 1, Name = "E-commerce Website", Description = "Develop an online store for a retail company." },
                new Project { ProjId = 2, Name = "Blog Platform", Description = "Create a web platform for bloggers to publish and share their content." },
                new Project { ProjId = 3, Name = "Mobile Game App", Description = "Develop a fun and engaging mobile game for iOS and Android platforms." }
            );

            modelBuilder.Entity<TimeReport>().HasData(
                new TimeReport(new DateTime(2023, 02, 01, 10, 00, 00), new DateTime(2023, 02, 01, 13, 00, 00)) { TRId = 1, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 03, 15, 08, 00, 00), new DateTime(2023, 03, 15, 11, 30, 00)) { TRId = 2, EmployeeId = 2 },
                new TimeReport(new DateTime(2023, 04, 05, 14, 00, 00), new DateTime(2023, 04, 05, 16, 00, 00)) { TRId = 3, EmployeeId = 3 },
                new TimeReport(new DateTime(2023, 05, 01, 09, 00, 00), new DateTime(2023, 05, 01, 10, 30, 00)) { TRId = 4, EmployeeId = 4 },
                new TimeReport(new DateTime(2023, 01, 20, 11, 00, 00), new DateTime(2023, 01, 20, 12, 00, 00)) { TRId = 5, EmployeeId = 5 },
                new TimeReport(new DateTime(2023, 02, 05, 08, 00, 00), new DateTime(2023, 02, 05, 10, 00, 00)) { TRId = 6, EmployeeId = 6 },
                new TimeReport(new DateTime(2023, 03, 22, 13, 00, 00), new DateTime(2023, 03, 22, 15, 00, 00)) { TRId = 7, EmployeeId = 7 },
                new TimeReport(new DateTime(2023, 04, 14, 12, 00, 00), new DateTime(2023, 04, 14, 14, 00, 00)) { TRId = 8, EmployeeId = 8 },
                new TimeReport(new DateTime(2023, 05, 01, 08, 00, 00), new DateTime(2023, 05, 01, 10, 00, 00)) { TRId = 9, EmployeeId = 9 },
                new TimeReport(new DateTime(2023, 01, 15, 09, 00, 00), new DateTime(2023, 01, 15, 11, 00, 00)) { TRId = 10, EmployeeId = 10 },
                new TimeReport(new DateTime(2023, 01, 10, 13, 00, 00), new DateTime(2023, 01, 10, 14, 30, 00)) { TRId = 11, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 01, 01, 08, 00, 00), new DateTime(2023, 01, 01, 10, 00, 00)) { TRId = 12, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 01, 02, 09, 00, 00), new DateTime(2023, 01, 02, 11, 00, 00)) { TRId = 13, EmployeeId = 2 },
                new TimeReport(new DateTime(2023, 01, 03, 10, 00, 00), new DateTime(2023, 01, 03, 12, 00, 00)) { TRId = 14, EmployeeId = 3 },
                new TimeReport(new DateTime(2023, 01, 04, 11, 00, 00), new DateTime(2023, 01, 04, 13, 00, 00)) { TRId = 15, EmployeeId = 4 },
                new TimeReport(new DateTime(2023, 01, 05, 12, 00, 00), new DateTime(2023, 01, 05, 14, 00, 00)) { TRId = 16, EmployeeId = 5 },
                new TimeReport(new DateTime(2023, 01, 06, 13, 00, 00), new DateTime(2023, 01, 06, 15, 00, 00)) { TRId = 17, EmployeeId = 6 },
                new TimeReport(new DateTime(2023, 01, 07, 14, 00, 00), new DateTime(2023, 01, 07, 16, 00, 00)) { TRId = 18, EmployeeId = 7 },
                new TimeReport(new DateTime(2023, 01, 08, 15, 00, 00), new DateTime(2023, 01, 08, 17, 00, 00)) { TRId = 19, EmployeeId = 8 },
                new TimeReport(new DateTime(2023, 01, 09, 16, 00, 00), new DateTime(2023, 01, 09, 18, 00, 00)) { TRId = 20, EmployeeId = 9 },
                new TimeReport(new DateTime(2023, 03, 05, 10, 00, 00), new DateTime(2023, 03, 05, 12, 00, 00)) { TRId = 21, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 04, 18, 08, 00, 00), new DateTime(2023, 04, 18, 11, 00, 00)) { TRId = 22, EmployeeId = 2 },
                new TimeReport(new DateTime(2023, 05, 01, 14, 00, 00), new DateTime(2023, 05, 01, 16, 00, 00)) { TRId = 23, EmployeeId = 3 },
                new TimeReport(new DateTime(2023, 01, 25, 12, 00, 00), new DateTime(2023, 01, 25, 14, 00, 00)) { TRId = 24, EmployeeId = 4 },
                new TimeReport(new DateTime(2023, 02, 10, 09, 00, 00), new DateTime(2023, 02, 10, 11, 00, 00)) { TRId = 25, EmployeeId = 5 },
                new TimeReport(new DateTime(2023, 03, 25, 08, 00, 00), new DateTime(2023, 03, 25, 11, 00, 00)) { TRId = 26, EmployeeId = 6 },
                new TimeReport(new DateTime(2023, 04, 10, 14, 00, 00), new DateTime(2023, 04, 10, 15, 30, 00)) { TRId = 27, EmployeeId = 7 },
                new TimeReport(new DateTime(2023, 05, 01, 08, 00, 00), new DateTime(2023, 05, 01, 09, 30, 00)) { TRId = 28, EmployeeId = 8 },
                new TimeReport(new DateTime(2023, 01, 20, 13, 00, 00), new DateTime(2023, 01, 20, 14, 00, 00)) { TRId = 29, EmployeeId = 9 },
                new TimeReport(new DateTime(2023, 02, 05, 10, 00, 00), new DateTime(2023, 02, 05, 12, 00, 00)) { TRId = 30, EmployeeId = 10 });

            modelBuilder.Entity<EmployeeProject>().HasKey(e => new {e.ProjId, e.EmpId});
            modelBuilder.Entity<EmployeeProject>().HasData(
                new {ProjId = 1, EmpId = 1 },
                new {ProjId = 1, EmpId = 2 },
                new {ProjId = 1, EmpId = 3 },
                new {ProjId = 1, EmpId = 4 },
                new {ProjId = 2, EmpId = 5 },
                new {ProjId = 2, EmpId = 6 },
                new {ProjId = 2, EmpId = 7 },
                new {ProjId = 2, EmpId = 8 },
                new {ProjId = 3, EmpId = 9 },
                new { ProjId = 3, EmpId = 10 },
                new { ProjId = 3, EmpId = 4 },
                new { ProjId = 3, EmpId = 5 },
                new { ProjId = 2, EmpId = 2 },
                new { ProjId = 2, EmpId = 3 },
                new { ProjId = 2, EmpId = 10 }
                );

        }
    }
}
