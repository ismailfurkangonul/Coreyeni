using Coreyeni.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Coreyeni.Data.Config
{
    public class CustomerConfig:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer>builder)
        {
            builder.Property(x => x.Name).IsRequired();    


        }
    }
}
