using System.ComponentModel.DataAnnotations.Schema;
using Amber.Data.EntityFramework;
using Amber.Lookups;
using Amber.Lookups.Entities;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.Contracts.Entity", Version = "1.0")]

namespace Mastermind.Data
{
    public class CategoryEntity : TenantEntity
    {
        public long CategoryId { get; set; }

        public string Name { get; set; }

        public int StorageTypeId
        {
            get => StoragetType.ToLookupId();
            set => StoragetType = value.ToLookupEnum<StorageTypeEnum>();
        }

        [NotMapped]
        public virtual StorageTypeEnum StoragetType { get; set; }

        public virtual LookupEntity StoragetTypeLookup { get; set; }

        public virtual ICollection<ToyEntity> ToyEntities { get; set; } = new HashSet<ToyEntity>();
    }
}