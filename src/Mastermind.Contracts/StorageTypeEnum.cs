using Amber.Annotations;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Qbic.Data.Contracts.DomainEnum", Version = "1.0")]

namespace Mastermind
{
    [LookupSet]
    public enum StorageTypeEnum
    {
        [LookupDescription("Stored on bookshelf")]
        Shelf = 1000,

        [LookupDescription("Stored in the box")]
        Box = 1001
    }
}