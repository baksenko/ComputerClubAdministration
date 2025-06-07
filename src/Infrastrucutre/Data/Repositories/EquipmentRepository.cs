using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data.Repositories;

public class EquipmentRepository(ComputerClubDbContext context) : EntityRepository<Equipment>(context)
{
    public async Task<Equipment?> GetEquipmentBySerialNumberAsync(string serialNumber)
    {
        var equipment = _context
            .Set<Equipment>()
            .AsNoTracking()
            .Where(x => x.SerialNumber == serialNumber)
            .FirstOrDefaultAsync();
        
        return await equipment;
    }
    
    public async Task<Equipment?> GetEquipmentByModelAsync(string model)
    {
        var equipment = _context
            .Set<Equipment>()
            .AsNoTracking()
            .Where(x => x.Model == model)
            .FirstOrDefaultAsync();
        
        return await equipment;
    }
}