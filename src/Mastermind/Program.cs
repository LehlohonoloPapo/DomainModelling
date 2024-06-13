using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Host.GeneratedProgram", Version = "1.0")]

namespace Mastermind
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateSlimBuilder(args).Init(args)
                .Register<MastermindApi>();

            var app = builder.Build();

            await app.RunAsync();
        }
    }
}