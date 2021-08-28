using InventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ExternalParty> ExternalParties { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePrivilege> RolePrivileges { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
