using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data.Repositories;

public class WorkStationRepository(ComputerClubDbContext context): EntityRepository<WorkStation>(context)
{
    public async Task<WorkStation?> FindWorkStationByType(string type)
    {
        var workstation = _context
            .Set<WorkStation>()
            .AsNoTracking()
            .Where(x => x.Type == type)
            .FirstOrDefaultAsync();
        
        return await workstation;
    }
    
    public async Task<WorkStation?> FindWorkStationByCategory(string category)
    {
        var workstation = _context
            .Set<WorkStation>()
            .AsNoTracking()
            .Where(x => x.Category == category)
            .FirstOrDefaultAsync();
        
        return await workstation;
    }
    
    public async Task<WorkStation?> FindWorkStationByCategory(int place)
    {
        var workstation = _context
            .Set<WorkStation>()
            .AsNoTracking()
            .Where(x => x.Place == place)
            .FirstOrDefaultAsync();
        
        return await workstation;
    }
}