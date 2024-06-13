using Amber.Data.EntityFramework;
using Intent.RoslynWeaver.Attributes;
using Microsoft.EntityFrameworkCore;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.Module.DbContextInterface", Version = "1.0")]

namespace Mastermind.Data;

public interface IMastermindDbContext : IAmberDbContext
{
    // db sets
    DbSet<CategoryEntity> CategoryEntities { get; set; }
    DbSet<ToyEntity> ToyEntities { get; set; }
}