using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.EfMigrations.IEfMigrationsMarker", Version = "1.0")]

namespace Mastermind.EntityMigration;

public interface IEfMigrationsMarker
{

}