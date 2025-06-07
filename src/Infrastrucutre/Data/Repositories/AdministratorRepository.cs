using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data.Repositories;

public class AdministratorRepository(ComputerClubDbContext context) : EntityRepository<Administrator>(context)
{
    public async Task<Administrator?> GetAdministratorByEmailAsync(string email)
    {
        var admin = _context
            .Set<Administrator>()
            .AsNoTracking()
            .Where(a => a.Email == email)
            .FirstOrDefaultAsync();
        
        return await admin;
    }

    public async Task<Administrator?> GetAdministratorByLoginAsync(string login)
    {
        var admin = _context
            .Set<Administrator>()
            .AsNoTracking()
            .Where(a => a.Login == login)
            .FirstOrDefaultAsync();
        
        return await admin;
    }
    
    public async Task<Administrator?> GetAdministratorByPhoneAsync(string phonenumber)
    {
        var admin = _context
            .Set<Administrator>()
            .AsNoTracking()
            .Where(u => u.Telephone == phonenumber)
            .FirstOrDefaultAsync();
        
        return await admin;
    }
}