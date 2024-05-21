using Model;
using Repository.Contract.IRepository;
using Repository.Repositories;
using Service.Contract.IRepository;

namespace Service.Services
{
    public class ProductsServiceService : IProductsServiceService
    {
        private readonly IProductServiceRepository _repo;
        public ProductsServiceService(IProductServiceRepository repo)
        {
            _repo = repo;
        }

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
            return await _repo.GetAllAsync();
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
