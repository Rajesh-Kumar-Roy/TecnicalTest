using Dapper;
using Model;
using Repository.Contract.IRepository;
using Repository.DataContext;
using System.Data;

namespace Repository.Repositories
{
    public class ProductServiceRepository : IProductServiceRepository
    {
        private readonly IDbConnection _db;
        public ProductServiceRepository(DapperContext context) => _db = context.GetDbConnection();

        public Task<int> AddAsync(ProductsService entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddListAsync(List<ProductsService> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductsService>> GetAllAsync()
        {
            using (IDbConnection db = _db)
            {
                string storedProcedure = "GetPRODUCTSERVICES";
                var result = await db.QueryAsync<ProductsService>(storedProcedure, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }

        public Task<ProductsService> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(ProductsService entity)
        {
            throw new NotImplementedException();
        }
    }
}
