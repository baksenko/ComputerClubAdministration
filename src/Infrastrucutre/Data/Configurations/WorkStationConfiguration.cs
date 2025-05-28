using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastrucutre.Data.Configurations;

public class WorkStationConfiguration : IEntityTypeConfiguration<WorkStation>
{
    public void Configure(EntityTypeBuilder<WorkStation> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.Sessions)
            .WithOne(x => x.WorkStation);

        builder.HasMany(x => x.Equipments)
            .WithOne(x => x.WorkStation);
    }
}