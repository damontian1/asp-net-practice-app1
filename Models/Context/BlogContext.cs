using Microsoft.EntityFrameworkCore;
using asp_practice_app.Models;

namespace asp_practice_app.Context {
  public class BlogContext : DbContext {
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) {

    }
    public DbSet<Post> Posts { get; set; }
  }
}