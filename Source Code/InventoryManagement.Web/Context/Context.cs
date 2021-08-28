using AutoMapper;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Domain.Structures;
using InventoryManagement.Web.Extentions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Context
{
    public static class Context
    {
        public static UserContext UserContext
        {
            get { return InventoryManagemetHttpContext.Current.Session.GetObject<UserContext>("UserContext"); }
        }

        public static void InitiateSession(User user, IMapper _mapper)
        {

            var userContext = _mapper.Map<UserContext>(user);
            userContext.IsSuperUser = user.Role != null && user.Role.IsSuperUser;
            userContext.Privileges = InitRolePrivileges(user.Role);

            InventoryManagemetHttpContext.Current.Session.SetObject("UserContext", userContext);
        }

        public static void TerminateSession()
        {
            InventoryManagemetHttpContext.Current.Session.SetObject("UserContext", null);
        }

        private static SecurityPrivileges InitRolePrivileges(UserRole role)
        {
            var secPriv = new SecurityPrivileges();

            if (role == null) return secPriv;

            PropertyInfo[] props = typeof(SecurityPrivileges).GetProperties();
            foreach (var p in props)
            {
                var displayNameAttr = (DisplayNameAttribute)p.GetCustomAttributes(typeof(DisplayNameAttribute), false).First();

                if (role.IsSuperUser)
                {
                    p.SetValue(secPriv, true, null);
                }
                else
                {
                    var existingPrivilege = role.Privileges?.FirstOrDefault(x => x.Name == p.Name);
                    if (existingPrivilege != null)
                    {
                        p.SetValue(secPriv, existingPrivilege.Value, null);
                    }
                }
            }

            return secPriv;
        }
    }

    public class UserContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSuperUser { get; set; }

        public SecurityPrivileges Privileges { get; set; }
    }

    public static class InventoryManagemetHttpContext
    {
        static IServiceProvider services = null;

        /// <summary>
        /// Provides static access to the framework's services provider
        /// </summary>
        public static IServiceProvider Services
        {
            get { return services; }
            set
            {
                if (services != null)
                {
                    throw new Exception("Can't set once a value has already been set.");
                }
                services = value;
            }
        }

        /// <summary>
        /// Provides static access to the current HttpContext
        /// </summary>
        public static HttpContext Current
        {
            get
            {
                IHttpContextAccessor httpContextAccessor = services.GetService(typeof(IHttpContextAccessor)) as IHttpContextAccessor;
                return httpContextAccessor?.HttpContext;
            }
        }

    }
}
