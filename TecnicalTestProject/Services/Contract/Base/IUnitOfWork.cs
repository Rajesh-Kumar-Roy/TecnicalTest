using Service.Contract.IRepository;

namespace Service.Contract.Base
{
    public interface IUnitOfWork
    {
        ICorporateCustomerService CorporateCustomer { get; }
        IIndividualCustomerService IndividualCustomer { get; }
        IProductsServiceService ProductsService { get; }
        IMeetingMinutesMasterService MeetingMinutesMaster { get; }
        ICustomerTypeService CustomerType { get; }
        IMeetingMinutesDetailsService MeetingMinutesDetails { get; }

    }
}
