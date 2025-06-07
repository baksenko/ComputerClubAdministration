using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data.Repositories;

public class ComputerClubRepository(ComputerClubDbContext context) : EntityRepository<ComputerClub>(context)
{
    public async Task<ComputerClub?> GetComputerclubByAdress(string adress)
    {
        var computerclub = _context
            .Set<ComputerClub>()
            .AsNoTracking()
            .Where(x => x.Address == adress)
            .FirstOrDefaultAsync();
        
        return await computerclub;
    }
    
    public async Task<ComputerClub?> GetComputerclubByName(string name)
    {
        var computerclub = _context
            .Set<ComputerClub>()
            .AsNoTracking()
            .Where(x => x.Name == name)
            .FirstOrDefaultAsync();
        
        return await computerclub;
    }
}