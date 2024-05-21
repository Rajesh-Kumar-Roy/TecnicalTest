using Dapper;
using Model;
using Repository.Contract.IRepository;
using Repository.DataContext;
using System.Data;

namespace Repository.Repositories
{
    public class IndividualCustomerRepository : IIndividualCustomerRepository
    {
        private readonly IDbConnection _db;
        public IndividualCustomerRepository(DapperContext context) => _db = context.GetDbConnection();

        public Task<int> AddAsync(IndividualCustomer entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddListAsync(List<IndividualCustomer> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IndividualCustomer>> GetAllAsync()
        {
            using (IDbConnection db = _db)
            {
                string storedProcedure = "GetIndividualCustomers";
                var result = await db.QueryAsync<IndividualCustomer>(storedProcedure, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public Task<IndividualCustomer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(IndividualCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
