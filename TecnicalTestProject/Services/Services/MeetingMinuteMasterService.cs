using Model;
using Repository.Contract.IRepository;
using Repository.Repositories;
using Service.Contract.IRepository;

namespace Service.Services
{
    public class MeetingMinuteMasterService : IMeetingMinutesMasterService
    {
        private readonly IMeetingMinutesMasterRepository _repo;
        public MeetingMinuteMasterService(IMeetingMinutesMasterRepository repo)
        {
            _repo = repo;
        }

        public async Task<int> AddAsync(MeetingMinutesMaster entity)
        {
           return await _repo.AddAsync(entity);
        }

        public Task<int> AddListAsync(List<MeetingMinutesMaster> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MeetingMinutesMaster>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MeetingMinutesMaster> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(MeetingMinutesMaster entity)
        {
            throw new NotImplementedException();
        }
    }
}
