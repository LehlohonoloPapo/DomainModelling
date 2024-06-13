using Intent.RoslynWeaver.Attributes;
using Mastermind.Data.Context;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Host.GeneratedProgram", Version = "1.0")]

namespace Mastermind.EntityMigration
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var builder = new HostApplicationBuilder(args).Init(args)
                .Register<MastermindEntityMigration>();

            return await builder.AsMigrationsAsync<MastermindDbContext>();
        }
    }
}