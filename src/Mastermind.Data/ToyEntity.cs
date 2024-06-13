using Amber.Data.EntityFramework;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.Contracts.Entity", Version = "1.0")]

namespace Mastermind.Data
{
    public class ToyEntity : TenantEntity
    {
        public string Name { get; set; }

        public long ToyID { get; set; }

        public virtual CategoryEntity CategoryId { get; set; }
    }
}