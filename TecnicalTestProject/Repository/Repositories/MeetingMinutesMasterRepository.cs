using Dapper;
using Microsoft.Data.SqlClient;
using Model;
using Repository.Contract.IRepository;
using Repository.DataContext;
using System.Data;
using System.Data.SqlTypes;

namespace Repository.Repositories
{
    public class MeetingMinutesMasterRepository : IMeetingMinutesMasterRepository
    {
        private readonly IDbConnection _db;
        public MeetingMinutesMasterRepository(DapperContext context) => _db = context.GetDbConnection();

        public async Task<int> AddAsync(MeetingMinutesMaster entity)
        {

            using (var connection = _db)
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {

                        var parameters = new DynamicParameters();
                        var datetimeCon  = entity.MeetingDate.ToDateTime(TimeOnly.MinValue);
                        TimeSpan meetingTimeSpan = entity.MeetingTime.ToTimeSpan();
                        parameters.Add("@MeetingDate", datetimeCon);
                        parameters.Add("@MeetingTime", meetingTimeSpan);
                        parameters.Add("@Place", entity.Place);
                        parameters.Add("@ClientSide", entity.ClientSide);
                        parameters.Add("@HostSide", entity.HostSide);
                        parameters.Add("@Agenda", entity.Agenda);
                        parameters.Add("@Discussion", entity.Discussion);
                        parameters.Add("@Decision", entity.Decision);
                        parameters.Add("@IndividualCustomerId", entity.IndividualCustomerId);
                        parameters.Add("@CorporateCustomerId", entity.CorporateCustomerId);
                        parameters.Add("@CustomerTypeId", entity.CustomerTypeId);
                       
                        parameters.Add("@NewId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                        await connection.ExecuteAsync("Meeting_Minutes_Master_Save_SP", parameters, transaction, commandType: CommandType.StoredProcedure);

                        int newId = parameters.Get<int>("@NewId");

                        var returnResult = 0;
                        foreach (var detail in entity.MeetingMinutesDetails)
                        {
                            var param = new DynamicParameters();
                            detail.MeetingMinutesMasterId = newId;


                            param.Add("@Quantity", detail.Quantity);
                            param.Add("@ProductsServiceId", detail.ProductsServiceId);
                            param.Add("@MeetingMinutesMasterId", detail.MeetingMinutesMasterId);

                            returnResult =await connection.ExecuteAsync("Meeting_Minutes_Details_Save_SP", param, transaction, commandType: CommandType.StoredProcedure);
                        }

                        transaction.Commit();
                        return returnResult;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

            }
        }
        public Task<int> AddListAsync(List<MeetingMinutesMaster> entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MeetingMinutesMaster>> GetAllAsync()
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
