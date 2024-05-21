using Model;
using Repository.Contract.IRepository;
using Service.Contract.IRepository;

namespace Service.Services
{
    public class CorporateCustomerService : ICorporateCustomerService
    {
        private readonly ICorporateCustomerRepository _repo;
        public CorporateCustomerService(ICorporateCustomerRepository repo)
        {
            _repo = repo;
        }
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
            return await _repo.GetAllAsync();
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
