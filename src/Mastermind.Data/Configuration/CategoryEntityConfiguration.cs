using Amber.Data.EntityFramework.Configuration;
using Amber.Lookups;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.Module.EntityTypeConfiguration", Version = "1.0")]

namespace Mastermind.Data.Configuration;

public class CategoryEntityConfiguration : EntityConfiguration<CategoryEntity>
{
    public override void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        base.Configure(builder);

        builder.ToTable("Category", "Mastermind");

        builder.HasKey(x => x.CategoryId);

        builder.Property(x => x.CategoryId)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.StorageTypeId)
            .IsRequired();

        builder.HasLookup(x => x.StoragetTypeLookup, x => x.StorageTypeId, true);
    }
}
