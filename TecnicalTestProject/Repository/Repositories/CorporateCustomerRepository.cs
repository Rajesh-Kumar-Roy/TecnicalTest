using Dapper;
using Microsoft.Data.SqlClient;
using Model;
using Repository.Contract.IRepository;
using Repository.DataContext;
using System.Data;

namespace Repository.Repositories
{
    public class CorporateCustomerRepository : ICorporateCustomerRepository
    {
        private readonly IDbConnection _db;
        public CorporateCustomerRepository(DapperContext context) => _db = context.GetDbConnection();
        public Task<int> AddAsync(CorporateCustomer entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddListAsync(List<CorporateCustomer> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CorporateCustomer>> GetAllAsync()
        {
            using (IDbConnection db = _db)
            {
                string storedProcedure = "GetCorporateCustomers";
                var result =  await db.QueryAsync<CorporateCustomer>(storedProcedure, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }    
        }

        public Task<CorporateCustomer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(CorporateCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
