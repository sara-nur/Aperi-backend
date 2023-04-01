using Microsoft.EntityFrameworkCore;

namespace Aperi_backend.Database;

public class AppDbContext : DbContext
{
    #region Constructor
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    #endregion

    #region Model creating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    #endregion
}
