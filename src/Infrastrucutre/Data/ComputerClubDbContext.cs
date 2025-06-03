using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Infrastrucutre.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastrucutre.Data;

public class ComputerClubDbContext : DbContext
{
    public ComputerClubDbContext(DbContextOptions<ComputerClubDbContext> options) : base(options)
    {
        try
        {
            var DatabaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            if (DatabaseCreator != null)
            {
                if (!DatabaseCreator.CanConnect()) DatabaseCreator.Create();
                if (!DatabaseCreator.HasTables()) DatabaseCreator.CreateTables();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public DbSet<Administrator> Administrators { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<ComputerClub> ComputerClubs { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<WorkStation> WorkStations { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AdministratorConfiguration());
        modelBuilder.ApplyConfiguration(new SessionConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new ComputerClubConfiguration());
        modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
        modelBuilder.ApplyConfiguration(new WorkStationConfiguration());
    }
    
}