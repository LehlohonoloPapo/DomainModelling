using Amber.Data.EntityFramework.Configuration;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.Module.EntityTypeConfiguration", Version = "1.0")]

namespace Mastermind.Data.Configuration;

public class ToyEntityConfiguration : EntityConfiguration<ToyEntity>
{
    public override void Configure(EntityTypeBuilder<ToyEntity> builder)
    {
        base.Configure(builder);

        builder.ToTable("Toy", "Mastermind");

        builder.HasKey(x => x.ToyID);

        builder.Property(x => x.ToyID)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .IsRequired();

        builder.HasOne(x => x.CategoryId)
            .WithMany(x => x.ToyEntities)
            .HasForeignKey(x => new { })
            .OnDelete(DeleteBehavior.Restrict);
    }
}
