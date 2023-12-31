﻿using System.ComponentModel.DataAnnotations;
using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Entities.Base;

public abstract class BaseEntity<TKey> : IBaseEntity where TKey : struct
{
    [Key]
    public TKey Id { get; set; }

    public RecordStatusEnum RecordStatus { get; set; }
    public DateTime CreateDate { get; set; }
    public string? CreateUserId { get; set; }

    public void Create(string createUserId)
    {
        RecordStatus = RecordStatusEnum.Active;
        CreateDate = DateTime.Now;
        CreateUserId = createUserId;
    }

}
