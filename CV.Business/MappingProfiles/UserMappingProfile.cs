using AutoMapper;
using CV.DTO.DTOs.AppUserDtos;
using CV.Entities.Concrete;

namespace CV.Business.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<AppUser, AppUserForListDto>();
        }
    }
}