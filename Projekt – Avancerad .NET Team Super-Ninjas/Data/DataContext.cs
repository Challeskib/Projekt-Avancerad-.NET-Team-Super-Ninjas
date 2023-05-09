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
                new Employee { EmployeeId = 1, Name = "Kalle Gustavsson", Email = "Kalle@företaget.com" },
                new Employee { EmployeeId = 2, Name = "Sara Andersson", Email = "Sara@företaget.com" },
                new Employee { EmployeeId = 3, Name = "Johan Svensson", Email = "Johan@företaget.com" },
                new Employee { EmployeeId = 4, Name = "Lisa Lindström", Email = "Lisa@företaget.com" },
                new Employee { EmployeeId = 5, Name = "Anders Nilsson", Email = "Anders@företaget.com" },
                new Employee { EmployeeId = 6, Name = "Emma Bergström", Email = "Emma@företaget.com" },
                new Employee { EmployeeId = 7, Name = "Peter Persson", Email = "Peter@företaget.com" },
                new Employee { EmployeeId = 8, Name = "Maria Karlsson", Email = "Maria@företaget.com" },
                new Employee { EmployeeId = 9, Name = "Erik Johansson", Email = "Erik@företaget.com" },
                new Employee { EmployeeId = 10, Name = "Anna Ahlström", Email = "Anna@företaget.com" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 1, Name = "E-commerce Website", Description = "Develop an online store for a retail company." },
                new Project { ProjectId = 2, Name = "Blog Platform", Description = "Create a web platform for bloggers to publish and share their content." },
                new Project { ProjectId = 3, Name = "Mobile Game App", Description = "Develop a fun and engaging mobile game for iOS and Android platforms." }
            );

            modelBuilder.Entity<TimeReport>().HasData(
                new TimeReport(new DateTime(2023, 02, 01, 10, 00, 00), new DateTime(2023, 02, 01, 13, 00, 00)) { Id = 1, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 03, 15, 08, 00, 00), new DateTime(2023, 03, 15, 11, 30, 00)) { Id = 2, EmployeeId = 2 },
                new TimeReport(new DateTime(2023, 04, 05, 14, 00, 00), new DateTime(2023, 04, 05, 16, 00, 00)) { Id = 3, EmployeeId = 3 },
                new TimeReport(new DateTime(2023, 05, 01, 09, 00, 00), new DateTime(2023, 05, 01, 10, 30, 00)) { Id = 4, EmployeeId = 4 },
                new TimeReport(new DateTime(2023, 01, 20, 11, 00, 00), new DateTime(2023, 01, 20, 12, 00, 00)) { Id = 5, EmployeeId = 5 },
                new TimeReport(new DateTime(2023, 02, 05, 08, 00, 00), new DateTime(2023, 02, 05, 10, 00, 00)) { Id = 6, EmployeeId = 6 },
                new TimeReport(new DateTime(2023, 03, 22, 13, 00, 00), new DateTime(2023, 03, 22, 15, 00, 00)) { Id = 7, EmployeeId = 7 },
                new TimeReport(new DateTime(2023, 04, 14, 12, 00, 00), new DateTime(2023, 04, 14, 14, 00, 00)) { Id = 8, EmployeeId = 8 },
                new TimeReport(new DateTime(2023, 05, 01, 08, 00, 00), new DateTime(2023, 05, 01, 10, 00, 00)) { Id = 9, EmployeeId = 9 },
                new TimeReport(new DateTime(2023, 01, 15, 09, 00, 00), new DateTime(2023, 01, 15, 11, 00, 00)) { Id = 10, EmployeeId = 10 },
                new TimeReport(new DateTime(2023, 01, 10, 13, 00, 00), new DateTime(2023, 01, 10, 14, 30, 00)) { Id = 11, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 01, 01, 08, 00, 00), new DateTime(2023, 01, 01, 10, 00, 00)) { Id = 12, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 01, 02, 09, 00, 00), new DateTime(2023, 01, 02, 11, 00, 00)) { Id = 13, EmployeeId = 2 },
                new TimeReport(new DateTime(2023, 01, 03, 10, 00, 00), new DateTime(2023, 01, 03, 12, 00, 00)) { Id = 14, EmployeeId = 3 },
                new TimeReport(new DateTime(2023, 01, 04, 11, 00, 00), new DateTime(2023, 01, 04, 13, 00, 00)) { Id = 15, EmployeeId = 4 },
                new TimeReport(new DateTime(2023, 01, 05, 12, 00, 00), new DateTime(2023, 01, 05, 14, 00, 00)) { Id = 16, EmployeeId = 5 },
                new TimeReport(new DateTime(2023, 01, 06, 13, 00, 00), new DateTime(2023, 01, 06, 15, 00, 00)) { Id = 17, EmployeeId = 6 },
                new TimeReport(new DateTime(2023, 01, 07, 14, 00, 00), new DateTime(2023, 01, 07, 16, 00, 00)) { Id = 18, EmployeeId = 7 },
                new TimeReport(new DateTime(2023, 01, 08, 15, 00, 00), new DateTime(2023, 01, 08, 17, 00, 00)) { Id = 19, EmployeeId = 8 },
                new TimeReport(new DateTime(2023, 01, 09, 16, 00, 00), new DateTime(2023, 01, 09, 18, 00, 00)) { Id = 20, EmployeeId = 9 },
                new TimeReport(new DateTime(2023, 03, 05, 10, 00, 00), new DateTime(2023, 03, 05, 12, 00, 00)) { Id = 21, EmployeeId = 1 },
                new TimeReport(new DateTime(2023, 04, 18, 08, 00, 00), new DateTime(2023, 04, 18, 11, 00, 00)) { Id = 22, EmployeeId = 2 },
                new TimeReport(new DateTime(2023, 05, 01, 14, 00, 00), new DateTime(2023, 05, 01, 16, 00, 00)) { Id = 23, EmployeeId = 3 },
                new TimeReport(new DateTime(2023, 01, 25, 12, 00, 00), new DateTime(2023, 01, 25, 14, 00, 00)) { Id = 24, EmployeeId = 4 },
                new TimeReport(new DateTime(2023, 02, 10, 09, 00, 00), new DateTime(2023, 02, 10, 11, 00, 00)) { Id = 25, EmployeeId = 5 },
                new TimeReport(new DateTime(2023, 03, 25, 08, 00, 00), new DateTime(2023, 03, 25, 11, 00, 00)) { Id = 26, EmployeeId = 6 },
                new TimeReport(new DateTime(2023, 04, 10, 14, 00, 00), new DateTime(2023, 04, 10, 15, 30, 00)) { Id = 27, EmployeeId = 7 },
                new TimeReport(new DateTime(2023, 05, 01, 08, 00, 00), new DateTime(2023, 05, 01, 09, 30, 00)) { Id = 28, EmployeeId = 8 },
                new TimeReport(new DateTime(2023, 01, 20, 13, 00, 00), new DateTime(2023, 01, 20, 14, 00, 00)) { Id = 29, EmployeeId = 9 },
                new TimeReport(new DateTime(2023, 02, 05, 10, 00, 00), new DateTime(2023, 02, 05, 12, 00, 00)) { Id = 30, EmployeeId = 10 });

            modelBuilder.Entity<EmployeeProject>().HasKey(e => new {e.ProjectId, e.EmployeeId});
            modelBuilder.Entity<EmployeeProject>().HasData(
                new { ProjectId = 1, EmployeeId = 1 },
                new { ProjectId = 1, EmployeeId = 2 },
                new { ProjectId = 1, EmployeeId = 3 },
                new { ProjectId = 1, EmployeeId = 4 },
                new { ProjectId = 2, EmployeeId = 5 },
                new { ProjectId = 2, EmployeeId = 6 },
                new { ProjectId = 2, EmployeeId = 7 },
                new { ProjectId = 2, EmployeeId = 8 },
                new { ProjectId = 3, EmployeeId = 9 },
                new { ProjectId = 3, EmployeeId = 10 },
                new { ProjectId = 3, EmployeeId = 4 },
                new { ProjectId = 3, EmployeeId = 5 },
                new { ProjectId = 2, EmployeeId = 2 },
                new { ProjectId = 2, EmployeeId = 3 },
                new { ProjectId = 2, EmployeeId = 10 }
                );

        }
    }
}
