using Dapper;
using Model;
using Repository.Contract.IRepository;
using Repository.DataContext;
using System.Data;

namespace Repository.Repositories
{
    public class MeetingMinuteDetailsRepository : IMeetingMinutesDetailsRepository
    {
        private readonly IDbConnection _db;
        public MeetingMinuteDetailsRepository(DapperContext context) => _db = context.GetDbConnection();

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
            using (IDbConnection db = _db)
            {
                string storedProcedure = "GetProuctServiceList";
                var result = await db.QueryAsync<MeetingMinutesDetails>(storedProcedure, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
        }
        public async Task<List<MasterDetailsRetrunModel>> GetAllMasterDetailsAsync()
        {
            using (IDbConnection db = _db)
            {
                string storedProcedure = "GetProuctServiceList";
                var result = await db.QueryAsync<MasterDetailsRetrunModel>(storedProcedure, commandType: CommandType.StoredProcedure);
                return result.ToList();
            }
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
