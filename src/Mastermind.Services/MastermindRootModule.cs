using Intent.RoslynWeaver.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Services.ServicePackageModuleV2", Version = "1.0")]

namespace Mastermind.Services
{
    /// <summary>
    /// Generated for amber framework verison: 8.1.*-preview.*
    /// Project reference added to contracts library containing: IDtoMarker
    /// </summary>
    public class MastermindRootModule : RootExtension
    {
        public override void Configure(IFeatureManager featureManager)
        {
            RegisterAdditionalModules(featureManager);
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        private void RegisterAdditionalModules(IFeatureManager featureManager)
        {
            // Add custom module registrations in this method
        }
    }
}