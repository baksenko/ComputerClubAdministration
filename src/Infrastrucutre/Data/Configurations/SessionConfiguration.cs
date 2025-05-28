using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastrucutre.Data.Configurations;

public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.WorkStation)
            .WithMany(x => x.Sessions);
        
        builder.HasOne(x => x.Administrator)
            .WithMany(x => x.Sessions);
        
        builder.HasOne(x => x.User)
            .WithMany(x => x.Sessions);
    }
}