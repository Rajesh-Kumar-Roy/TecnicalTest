namespace Service.Contract.Base;

public interface IBaseService<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task<int> AddAsync(T entity);
    Task<int> AddListAsync(List<T> entity);

    Task<int> UpdateAsync(T entity);
    Task<int> DeleteAsync(int id);

}


