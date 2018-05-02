﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SchoolExpress.Data.DbContexts
{
    public class SchoolExpressDbContext : IdentityDbContext<IdentityUser>
    {
        public SchoolExpressDbContext() : base("SchoolExpressConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer(new SchoolExpressInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("User");
            modelBuilder.Entity<IdentityRole>().ToTable("Role");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            modelBuilder.Properties<string>()
                .Configure(s => s.HasMaxLength(100).HasColumnType("NVARCHAR"));
            modelBuilder.Entity<IdentityUser>().Property(p => p.Id).HasMaxLength(36);
            modelBuilder.Entity<IdentityRole>().Property(p => p.Id).HasMaxLength(36);
            modelBuilder.Entity<IdentityUserClaim>().Property(p => p.UserId).HasMaxLength(36);
            modelBuilder.Entity<IdentityUserLogin>().Property(p => p.UserId).HasMaxLength(36);
            modelBuilder.Entity<IdentityUserRole>().Property(p => p.UserId).HasMaxLength(36);
            modelBuilder.Entity<IdentityUserRole>().Property(p => p.RoleId).HasMaxLength(36);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                               type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configInstance);
            }
        }
    }
}