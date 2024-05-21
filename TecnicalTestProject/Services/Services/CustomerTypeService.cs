using Model;
using Repository.Contract.IRepository;
using Service.Contract.IRepository;

namespace Service.Services
{
    public class CustomerTypeService : ICustomerTypeService
    {
        private readonly ICustomerTypeRepository _repo;
        public CustomerTypeService(ICustomerTypeRepository repo)
        {
            _repo = repo;
        }

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
           return await _repo.GetAllAsync();
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
