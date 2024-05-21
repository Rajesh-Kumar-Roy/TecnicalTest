using Model;
using Service.Contract.Base;

namespace Service.Contract.IRepository
{
    public interface IMeetingMinutesDetailsService : IBaseService<MeetingMinutesDetails>
    {
        Task<List<MasterDetailsRetrunModel>> GetAllMasterDetailsAsync();
    }
}
