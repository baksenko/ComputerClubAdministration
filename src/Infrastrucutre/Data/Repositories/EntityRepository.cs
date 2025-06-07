using Core.Entities;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Data.Repositories;

public abstract class EntityRepository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly ComputerClubDbContext _context;

    public EntityRepository(ComputerClubDbContext context)
    {
        _context = context;
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        var entity = await _context
            .Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
        
        if (entity == null) return null;
        
        return entity;
    }

    public async Task<List<T>?> GetAllAsync()
    {
        var users = await _context
            .Set<T>()
            .AsNoTracking()
            .ToListAsync();
        
        if (users.Count == 0) return null;
        
        return users;
    }

    public async Task<T?> UpdateAsync(T entity)
    {
         var exists =  await _context
            .Set<T>()
            .AnyAsync(x => x.Id == entity.Id);
         
         if (!exists) return null;
         
         _context.Update(entity);
        await _context.SaveChangesAsync();
        
        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var entity =  await _context
            .Set<T>()
            .FirstOrDefaultAsync(x => x.Id == id);
         
        if (entity == null) return false;
        
        _context
            .Set<T>()
            .Remove(entity);
        
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<T?> CreateAsync(T entity)
    {
        _context.Add(entity);
        
        await _context.SaveChangesAsync();
        
        return entity;
    }
}