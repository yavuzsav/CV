using CV.DTO.DTOs.AppUserDtos;
using CV.Entities.Concrete;

namespace CV.Business.Interfaces
{
    public interface IAppUserService
    {
        public bool Authenticate(string userName, string password);
        public AppUserForListDto FindByUserName(string userName);
    }
}