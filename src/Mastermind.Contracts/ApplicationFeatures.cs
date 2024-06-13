using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Settings.RootFeaturesHelper", Version = "1.0")]

namespace Mastermind;

public partial class ApplicationFeatures
{
    // root partial for the modules to extend. created once
}