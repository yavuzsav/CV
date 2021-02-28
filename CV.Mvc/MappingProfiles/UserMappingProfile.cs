using AutoMapper;
using CV.DTO.DTOs.AppUserDtos;
using CV.Mvc.Models;

namespace CV.Mvc.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<AppUserForListDto, AppUserUpdateModel>();
        }
    }
}