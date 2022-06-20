namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    { 
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task DeleteAsnyc(int id);

        Task<T?> GetAsync(int? id);

        Task AddRangeAysnc(List<T> entities);

        Task<bool> Exists(int? id);
    }
}
