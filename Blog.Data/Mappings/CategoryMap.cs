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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("{F2E461BB-875D-4D0A-AFF7-F8DB21F937A1}"),
                Name = "aspnet core ",
                CreatedBy="admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Category
            {
                Id = Guid.Parse("{A528849A-4D7F-431B-8C06-640BDDEF8D5A}"),
                Name = "aspnet core ",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
        }
    }
}