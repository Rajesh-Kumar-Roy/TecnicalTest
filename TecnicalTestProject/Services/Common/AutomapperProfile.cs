using AutoMapper;
using Model;
using Model.ViewModels;

namespace Service.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<MeetingMinutesMaster, MeetingMinutesMasterVm>().ReverseMap();
            this.CreateMap<MeetingMinutesDetails, MeetingMinutesDetailsVm>().ReverseMap();
        }
    }
}
