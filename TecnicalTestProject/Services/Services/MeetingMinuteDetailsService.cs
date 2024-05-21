using Model;
using Repository.Contract.IRepository;
using Service.Contract.IRepository;

namespace Service.Services
{
    public class MeetingMinuteDetailsService : IMeetingMinutesDetailsService
    {
        private readonly IMeetingMinutesDetailsRepository _repo;
        public MeetingMinuteDetailsService(IMeetingMinutesDetailsRepository repo)
        {
            _repo = repo;
        }

        public Task<int> AddAsync(MeetingMinutesDetails entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddListAsync(List<MeetingMinutesDetails> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MeetingMinutesDetails>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<List<MasterDetailsRetrunModel>> GetAllMasterDetailsAsync()
        {
            return await _repo.GetAllMasterDetailsAsync();
        }

        public Task<MeetingMinutesDetails> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(MeetingMinutesDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
