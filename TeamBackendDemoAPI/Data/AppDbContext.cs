using Microsoft.EntityFrameworkCore;
using TeamBackendDemoAPI.Models;

namespace TeamBackendDemoAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<FormData> FormDatas { get; set; }
}
