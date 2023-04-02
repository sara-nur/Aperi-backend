using Aperi_backend.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aperi_backend.Database.Seeds
{
    public class NfcSeed : IEntityTypeConfiguration<NfcCardOrTag>
    {
        public void Configure(EntityTypeBuilder<NfcCardOrTag> builder)
        {
            _ = builder.HasData(
                new NfcCardOrTag()
                {
                    Id = "95381EE7" //Card
                },
                new NfcCardOrTag()
                {
                    Id = "2DC951D3" //Tag
                });
        }
    }
}
