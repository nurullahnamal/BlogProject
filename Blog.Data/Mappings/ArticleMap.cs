using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp net Deneme makalesi",
                Content = "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa---------------------",
                ViewCount = 15,
                CategoryId = Guid.Parse("{F2E461BB-875D-4D0A-AFF7-F8DB21F937A1}"),
                ImageId=Guid.Parse("{3654C9A2-82C0-4E22-9479-7DB9069FE409}"),
                CreatedBy = "Test",
                CreatedDate = DateTime.Now,

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp net Deneme 212i",
                Content = "---------------dwa---------------------ddwa---------------------ddwa---------------------ddwa-----",
                ViewCount = 16,
                CategoryId= Guid.Parse("{A528849A-4D7F-431B-8C06-640BDDEF8D5A}"),
                ImageId= Guid.Parse("{903BD50C-1C68-4FB2-BB32-2B4AA7D9900D}"),
                CreatedBy = "Test",
                CreatedDate = DateTime.Now
            });

        }
    }
}
