using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastrucutre.Data.Configurations;

public class ComputerClubConfiguration : IEntityTypeConfiguration<ComputerClub>
{
    public void Configure(EntityTypeBuilder<ComputerClub> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasMany(x => x.Administrators)
            .WithOne(x => x.ComputerClub);
        
        builder.HasMany(x => x.WorkStations)
            .WithOne(x => x.ComputerClub);
    }
}