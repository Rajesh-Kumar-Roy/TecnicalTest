using Dapper;
using Model;
using Repository.Contract.IRepository;
using Repository.DataContext;
using System.Data;

namespace Repository.Repositories
{
    public class CustomerTypeRepository : ICustomerTypeRepository
    {
        private readonly IDbConnection _db;
        public CustomerTypeRepository(DapperContext context) => _db = context.GetDbConnection();

        public Task<int> AddAsync(CustomerType entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddListAsync(List<CustomerType> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomerType>> GetAllAsync()
        {
            using (IDbConnection db = _db)
            {
                string storedProcedure = "GetCustomerTypes";
                var result = await db.QueryAsync<CustomerType>(storedProcedure, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public Task<CustomerType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(CustomerType entity)
        {
            throw new NotImplementedException();
        }
    }
}
