using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PremiumAccount.Models;
using Microsoft.AspNetCore.Identity;

namespace PremiumAccount.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>(entity => entity.Property
            		(p => p.Id).HasMaxLength(128));
            builder.Entity<IdentityUser>(entity => entity.Property
           		 	(p => p.NormalizedEmail).HasMaxLength(128));
            builder.Entity<IdentityUser>(entity => entity.Property
            		(p => p.NormalizedUserName).HasMaxLength(128));

            builder.Entity<IdentityRole>(entity => entity.Property
            		(p => p.Id).HasMaxLength(128));
            builder.Entity<IdentityRole>(entity => entity.Property
            		(p => p.NormalizedName).HasMaxLength(128));


            builder.Entity<IdentityUserRole<string>>(entity => entity.Property
            		(p => p.UserId).HasMaxLength(128));
            builder.Entity<IdentityUserRole<string>>(entity => entity.Property
            		(p => p.RoleId).HasMaxLength(128));


            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property
            		(p => p.LoginProvider).HasMaxLength(100));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property
            		(p => p.ProviderKey).HasMaxLength(100));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property
            		(p => p.UserId).HasMaxLength(100));
            builder.Entity<IdentityUserLogin<string>>(entity=> entity.Property(
                p=>p.ProviderDisplayName).HasMaxLength(100));

            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property
            		(p => p.Id).HasMaxLength(128));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property
            		(p => p.UserId).HasMaxLength(128));

            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property
            		(p => p.Id).HasMaxLength(128));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property
            		(p => p.RoleId).HasMaxLength(128));
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostViewCount> PostViewCount { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }



    }

}

