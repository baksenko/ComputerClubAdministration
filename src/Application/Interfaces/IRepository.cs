namespace Application.Interfaces;

public interface IRepository<T> where T : class
{
    public Task<T?> CreateAsync(T entity);
    public Task<T?> UpdateAsync(T entity);
    public Task<bool> DeleteAsync(Guid id);
    public Task<T?> GetByIdAsync(Guid id);
    public Task<List<T>?> GetAllAsync();
}