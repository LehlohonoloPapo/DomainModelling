using Intent.RoslynWeaver.Attributes;
using Mastermind;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Host.ApplicationRootModule", Version = "1.0")]

namespace Mastermind
{
    public class MastermindApi : RootExtension
    {
        public override void Configure(IFeatureManager featureManager)
        {
            AmberModule.Register<DefaultSettings>();
            AmberModule.Register<AmberHttp>();

            RegisterAdditionalModules(featureManager);
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        private void RegisterAdditionalModules(IFeatureManager featureManager)
        {
            // Add custom module registrations in this method
        }
    }
}