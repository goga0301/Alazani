using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Entities.Base
{
    public interface ISoftDeleteEntity
    {
        RecordStatusEnum RecordStatus { get; set; }
    }
}
