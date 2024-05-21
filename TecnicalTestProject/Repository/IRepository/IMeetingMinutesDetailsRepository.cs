using Model;
using Repository.Contract.IRepository.Base;

namespace Repository.Contract.IRepository
{
    public interface IMeetingMinutesDetailsRepository : IBaseRepository<MeetingMinutesDetails>
    {
        Task<List<MasterDetailsRetrunModel>> GetAllMasterDetailsAsync();
    }
}
