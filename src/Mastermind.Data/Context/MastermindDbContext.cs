using Amber.Data.EntityFramework;
using Amber.Data.EntityFramework.Configuration;
using Amber.Validation;
using Intent.RoslynWeaver.Attributes;
using Mastermind.Data.Configuration;
using Microsoft.EntityFrameworkCore;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.Module.DbContext", Version = "1.0")]

namespace Mastermind.Data.Context;

[MigrationsTable(Name = "__EFMigrationsHistory", Schema = "Mastermind")]
public class MastermindDbContext : AmberDbContext, IMastermindDbContext
{

    public MastermindDbContext(DbContextOptions<MastermindDbContext> options,
            IEnumerable<IEntityTypeConfigurationExtension> entityConfigurations) : base(options, entityConfigurations)
    {
    }

    public virtual DbSet<CategoryEntity> CategoryEntities { get; set; }
    public virtual DbSet<ToyEntity> ToyEntities { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {

        var result = await base.SaveChangesAsync(cancellationToken);

        return result;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Mastermind");

        base.OnModelCreating(modelBuilder);

        // these are no longer needed. They are now registered by convention
        // To create configurations create a public class that implements IEntityTypeConfigurationExtension. 
        // These will be discovered and injected automatically.

        // this block will be kept for visibility
        // modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
        // modelBuilder.ApplyConfiguration(new ToyEntityConfiguration());
    }


}