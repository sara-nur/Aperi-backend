using Aperi_backend.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aperi_backend.Database;

public class AppDbContext : DbContext
{
    #region Constructor
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    #endregion

    #region Database sets
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<NfcCode> NfcCodes { get; set; }
    #endregion

    #region Model creating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    #endregion
}
