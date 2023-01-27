namespace Core_MVC_pet_project.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<int> GetCountAsync();
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
    }
    
}
