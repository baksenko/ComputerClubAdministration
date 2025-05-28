using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastrucutre.Data.Configurations;

public class AdministratorConfiguration : IEntityTypeConfiguration<Administrator>
{
    public void Configure(EntityTypeBuilder<Administrator> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.Sessions)
            .WithOne(x => x.Administrator);

        builder.HasOne(x => x.ComputerClub)
            .WithMany(x => x.Administrators);
    }
}