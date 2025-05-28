using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data;

public class ComputerClubDbContext(DbContextOptions<ComputerClubDbContext> options) : DbContext(options)
{
    public DbSet<Administrator> Administrators { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<ComputerClub> ComputerClubs { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<WorkStation> WorkStations { get; set; }

    public override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
}