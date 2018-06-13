using Microsoft.EntityFrameworkCore;
using asp_practice_app.Models;

namespace asp_practice_app.Context {
  public class ContactsDbContext : DbContext {
    public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options) {

    }
    public DbSet<Contact> Contacts { get; set; }
  }
}