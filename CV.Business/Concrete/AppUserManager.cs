using AutoMapper;
using CV.Business.HashTool;
using CV.Business.Interfaces;
using CV.DataAccess.Interfaces;
using CV.DTO.DTOs.AppUserDtos;
using CV.Entities.Concrete;

namespace CV.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper _mapper;

        public AppUserManager(IAppUserRepository userRepository, IPasswordHasher passwordHasher, IMapper mapper)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public bool Authenticate(string userName, string password)
        {
            var passwordHash = _userRepository.GetPasswordHashByUserName(userName);

            if (passwordHash == null) return false;

            var check = _passwordHasher.Check(passwordHash, password);

            return check && _userRepository.Authenticate(userName, passwordHash);
        }

        public AppUserForListDto FindByUserName(string userName)
        {
            var user = _userRepository.FindByUserName(userName);

            return _mapper.Map<AppUser, AppUserForListDto>(user);
        }
    }
}