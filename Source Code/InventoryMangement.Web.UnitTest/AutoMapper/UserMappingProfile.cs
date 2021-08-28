using AutoMapper;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Web.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMangement.Web.UnitTest.AutoMapper
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserContext>()
                .ForMember(dest => dest.Id, o => o.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, o => o.MapFrom(src => src.Name))
                .ForMember(dest => dest.IsSuperUser, o => o.MapFrom(src => src.Role.IsSuperUser));
        }
    }
}
