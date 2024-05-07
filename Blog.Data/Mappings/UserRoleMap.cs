using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");



            builder.HasData(new AppUserRole
            {
                UserId= Guid.Parse("945B2D6B-7E8A-4938-A485-7F729BADE00A"),
                RoleId= Guid.Parse("F3F18BAE-431E-44E7-B1B2-79EE4621DD24")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("1713C70C-1EF6-4201-B5FB-73E28054822C"),
                RoleId = Guid.Parse("E524514B-F771-4793-A579-65F546E54009"),
            });
        }

        
    }
}
