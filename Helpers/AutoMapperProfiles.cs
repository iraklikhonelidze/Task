using AutoMapper;
using CRUD.API;
using CRUD.API.Models;
using Task.Dtos;

namespace Task.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, AddUserDto>().ReverseMap();
            CreateMap<Gender, AddGenderDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<Gender, UpdateGenderDto>().ReverseMap();
        }
    }
}