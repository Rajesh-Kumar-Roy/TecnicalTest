using Model;
using Repository.Contract.IRepository;
using Repository.Repositories;
using Service.Contract.Base;
using Service.Contract.IRepository;

namespace Service.Services
{
    public class UnitOfWork : IUnitOfWork
    {
       
        private readonly ICorporateCustomerRepository _corporateCustomerRepository;
        private readonly IIndividualCustomerRepository _individualCustomerRepository;
        private readonly IProductServiceRepository _productServiceRepository;
        private readonly ICustomerTypeRepository _customerTypeRepository;
        private readonly IMeetingMinutesMasterRepository _meetingMinutesMasterRepository;
        private readonly IMeetingMinutesDetailsRepository _meetingMinutesDetailsRepository;

        public ICustomerTypeService CustomerType { get; private set; }
        public ICorporateCustomerService CorporateCustomer { get; private set; }
        public IIndividualCustomerService IndividualCustomer { get; private set; }
        public IProductsServiceService ProductsService { get; private set; }
        public IMeetingMinutesMasterService MeetingMinutesMaster { get; private set; }
        public IMeetingMinutesDetailsService MeetingMinutesDetails { get; private set; }
        public UnitOfWork(
             ICorporateCustomerRepository corporateCustomerRepository, 
             IIndividualCustomerRepository individualCustomerRepository,
             IProductServiceRepository productServiceRepository,
             ICustomerTypeRepository customerTypeRepository, 
             IMeetingMinutesMasterRepository meetingMinutesMasterRepository,
             IMeetingMinutesDetailsRepository meetingMinutesDetailsRepository
            )
        {
            _corporateCustomerRepository = corporateCustomerRepository;
            _individualCustomerRepository= individualCustomerRepository;
            _customerTypeRepository =   customerTypeRepository;
            _productServiceRepository = productServiceRepository;
            _meetingMinutesMasterRepository = meetingMinutesMasterRepository;
            _meetingMinutesDetailsRepository = meetingMinutesDetailsRepository;

            CustomerType = new CustomerTypeService(_customerTypeRepository);
            CorporateCustomer = new CorporateCustomerService(_corporateCustomerRepository);
            IndividualCustomer = new IndividualCustomerService(_individualCustomerRepository);
            ProductsService = new ProductsServiceService(_productServiceRepository);
            MeetingMinutesMaster = new MeetingMinuteMasterService(_meetingMinutesMasterRepository);
            MeetingMinutesDetails = new MeetingMinuteDetailsService(_meetingMinutesDetailsRepository);
        }
    }
}
