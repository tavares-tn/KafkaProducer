using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class ExampleMapping : IEntityTypeConfiguration<ExampleEntity>
    {
        public void Configure(EntityTypeBuilder<ExampleEntity> builder)
        {
            builder.ToTable("Example");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name);

            builder.Property(e => e.Age);

            builder.Property(e => e.Created);

            builder.Property(e => e.Updated);

            builder.Property(e => e.Deleted)
                   .HasDefaultValue(false);
                   
        }
    }
}
