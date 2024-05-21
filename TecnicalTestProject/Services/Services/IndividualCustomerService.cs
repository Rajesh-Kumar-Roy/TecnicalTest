using Model;
using Repository.Contract.IRepository;
using Service.Contract.IRepository;

namespace Service.Services
{
    public class IndividualCustomerService : IIndividualCustomerService
    {
        private readonly IIndividualCustomerRepository _repo;
        public IndividualCustomerService(IIndividualCustomerRepository repo)
        {
            _repo = repo;
        }

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
            return await _repo.GetAllAsync();
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
