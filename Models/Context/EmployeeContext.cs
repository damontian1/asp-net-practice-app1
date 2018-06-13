using Microsoft.EntityFrameworkCore;
using asp_practice_app.Models;

namespace asp_practice_app.Context {
  public class EmployeeContext : DbContext {
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) {}
    public DbSet<Employee> Employees { get; set; }
  }
}