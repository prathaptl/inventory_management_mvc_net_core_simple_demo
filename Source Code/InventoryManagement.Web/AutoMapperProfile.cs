using AutoMapper;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Web.Context;
using InventoryManagement.Web.Models;

namespace InventoryManagement.Web
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserViewModel, User>()
               .ForMember(x => x.Role, y => y.Ignore());

            CreateMap<User, UserViewModel>();

            CreateMap<UserRole, BasicEntityViewModel>();

            CreateMap<User, UserListViewModel>();

            CreateMap<UserRole, UserRoleListViewModel>();

            CreateMap<UserRoleViewModel, UserRole>()
               .ForMember(x => x.Privileges, y => y.Ignore()).ReverseMap();

            CreateMap<User, UserContext>();

            CreateMap<Product, ProductListViewModel>();

            CreateMap<Product, ProductViewModel>().ReverseMap();
        }

    }
}