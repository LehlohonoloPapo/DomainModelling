using Amber.Data.EntityFramework;
using Amber.Data.EntityFramework.DependencyInjection;
using Amber.Lookups;
using Intent.RoslynWeaver.Attributes;
using Mastermind.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.DomainPackageModuleV2", Version = "1.0")]

namespace Mastermind.Data
{
    /// <summary>
    /// Generated for amber framework version: 8.1.*-preview.*
    /// Project reference added to contracts library containing: IDtoMarker
    /// </summary>
    public class MastermindContextModule : IServicesExtension
    {
        private readonly Type _migrationsMarker;

        public MastermindContextModule(Type migrationsMarker)
        {
            _migrationsMarker = migrationsMarker;
        }

        public MastermindContextModule()
        {
            _migrationsMarker = null;
        }

        public IServiceCollection ConfigureServices(IServiceCollection services, IFeatureManager featureManager)
        {
            services.AddAmberDbContext<IMastermindDbContext, MastermindDbContext>(featureManager, _migrationsMarker, ServiceLifetime.Scoped);
            services.AddLookupDbContext<MastermindDbContext>(featureManager, ServiceLifetime.Scoped);

            return services;
        }
    }
}