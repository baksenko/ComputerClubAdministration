using System.Runtime.CompilerServices;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data.Repositories;

public class UserRepository : EntityRepository<User>
{

    public UserRepository(ComputerClubDbContext context) : base(context)
    {
    }
    
    
}