using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Host.DefaultApplicationSettings", Version = "1.0")]

namespace Mastermind
{
    internal sealed class DefaultSettings : ConfiguredAppSettingsExtension<DefaultSettings>
    {
        public DocumentationSettings Documentation => new DocumentationSettings()
        {
            Area = "Hackweel",
            ShortName = "Mastermind"
        };
    }
}