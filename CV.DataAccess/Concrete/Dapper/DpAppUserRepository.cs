using System.Data;
using CV.DataAccess.Interfaces;
using CV.Entities.Concrete;
using Dapper;

namespace CV.DataAccess.Concrete.Dapper
{
    public class DpAppUserRepository : DpGenericRepository<AppUser>, IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public DpAppUserRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }


        public bool Authenticate(string userName, string passwordHash)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>(
                $"select * from AppUsers where Username=@userName and PasswordHash=@password",
                new
                {
                    userName,
                    passwordHash
                });
            return user != null;
        }

        public string GetPasswordHashByUserName(string userName)
        {
            var passwordHash = _dbConnection.QueryFirstOrDefault<string>(
                $"select PasswordHash from AppUsers where Username=@userName", new
                {
                    userName
                });
            return passwordHash;
        }

        public AppUser FindByUserName(string userName)
        {
            return _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where Username=@userName",
                new
                {
                    userName
                });
        }
    }
}