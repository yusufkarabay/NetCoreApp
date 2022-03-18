using App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Seed
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = Guid.NewGuid(),CreatedDate=DateTime.Now,Deleted=false,Enabled=false,Name="Bilgisayarlar",UpdatedDate=DateTime.Now},
                new Category { Id = Guid.NewGuid(), CreatedDate=DateTime.Now, Deleted=false, Enabled=false, Name="Monitörler", UpdatedDate=DateTime.Now }
            );  
        }
    }
}
