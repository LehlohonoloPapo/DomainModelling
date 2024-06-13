using Intent.RoslynWeaver.Attributes;
using Mastermind.Data;
using Mastermind.EntityMigration;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Host.ApplicationRootModule", Version = "1.0")]

namespace Mastermind.EntityMigration
{
    public class MastermindEntityMigration : RootExtension
    {
        public override void Configure(IFeatureManager featureManager)
        {
            AmberModule.Register(new MastermindContextModule(GetType()));
            AmberModule.Register<DefaultSettings>();
            AmberModule.Register<AmberEntityMigration>();

            RegisterAdditionalModules(featureManager);
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        private void RegisterAdditionalModules(IFeatureManager featureManager)
        {
            // Add custom module registrations in this method
        }
    }
}