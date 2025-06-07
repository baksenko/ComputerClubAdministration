using System.Runtime.CompilerServices;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data.Repositories;

public class UserRepository(ComputerClubDbContext context) : EntityRepository<User>(context)
{
    public async Task<User?> GetUserByEmail(string email)
    {
        var user = _context
            .Set<User>()
            .AsNoTracking()
            .Where(u => u.Email == email)
            .FirstOrDefaultAsync();
        
        return await user;
    }
    
    public async Task<User?> GetUserByPhone(string phonenumber)
    {
        var user = _context
            .Set<User>()
            .AsNoTracking()
            .Where(u => u.Telephone == phonenumber)
            .FirstOrDefaultAsync();
        
        return await user;
    }
    
    
    
}