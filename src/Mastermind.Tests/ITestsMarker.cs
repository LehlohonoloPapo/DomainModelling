using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Tests.ITestsMarker", Version = "1.0")]

namespace Mastermind.Tests;

public interface ITestsMarker
{
    // Generated for amber framework verison: 8.1.*-preview.*
}