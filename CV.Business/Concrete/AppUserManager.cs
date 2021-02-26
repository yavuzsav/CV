using CV.Business.HashTool;
using CV.Business.Interfaces;
using CV.DataAccess.Interfaces;

namespace CV.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public AppUserManager(IAppUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public bool Authenticate(string userName, string password)
        {
            var passwordHash = _userRepository.GetPasswordHashByUserName(userName);

            if (passwordHash == null) return false;

            var check = _passwordHasher.Check(passwordHash, password);

            return check && _userRepository.Authenticate(userName, passwordHash);
        }
    }
}