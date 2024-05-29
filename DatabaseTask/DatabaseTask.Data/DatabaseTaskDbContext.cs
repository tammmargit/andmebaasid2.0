using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.

        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee2> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<AccessPermission> AccessPermissions { get; set; }
        public DbSet<SickDays> SickDays { get; set; }
        public DbSet<HealthExamination> HealthExaminations { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<LendableItem> LendableItems { get; set; }
        public DbSet<Loan> Loans { get; set; }

    }
}
