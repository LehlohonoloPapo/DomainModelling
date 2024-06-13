using Amber.Data.EntityFramework.Configuration;
using Amber.Lookups;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.EfMigrations.SeedEnumerationLookups", Version = "1.0")]

namespace Mastermind.EntityMigration.Seed
{
    public sealed class SeedEnumerationLookups : EntityConfigurationDependency
    {
        public override void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedLookupEnum<StorageTypeEnum>();
        }
    }
}