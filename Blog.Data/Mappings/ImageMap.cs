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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("3654C9A2-82C0-4E22-9479-7DB9069FE409"),
                FileName = "dwadaw",
                FileType = "png",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },

            new Image
            {
                Id = Guid.Parse("903BD50C-1C68-4FB2-BB32-2B4AA7D9900D"),
                FileName = "dwadaw",
                FileType = "png",
                CreatedBy="Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
                
            });
        }
    }
}
