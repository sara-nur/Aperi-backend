using Aperi_backend.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aperi_backend.Database.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            _ = builder.HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Sara",
                    LastName = "Nuredinovski",
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Haris",
                    LastName = "Kordić",
                });
        }
    }
}
