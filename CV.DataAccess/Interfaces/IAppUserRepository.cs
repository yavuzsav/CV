using CV.Entities.Concrete;

namespace CV.DataAccess.Interfaces
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        bool Authenticate(string userName, string passwordHash);
        string GetPasswordHashByUserName(string userName);
        AppUser FindByUserName(string userName);
    }
}