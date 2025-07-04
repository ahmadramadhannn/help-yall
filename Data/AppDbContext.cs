using HelpYAll.Model.Cpu;
using HelpYAll.Model.Todo;
using Microsoft.EntityFrameworkCore;

namespace HelpYAll.Data.AppDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
    public DbSet<Cpu> Cpus { get; set; }

}