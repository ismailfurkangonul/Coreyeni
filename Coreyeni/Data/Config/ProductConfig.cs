using Coreyeni.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coreyeni.Data.Config
{
    public class ProductConfig:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

        builder.Property(x => x.Name).IsRequired();
        }
    }
}
                    