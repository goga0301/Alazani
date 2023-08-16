using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Models.Domain;

public record CurrencyModel(int Id,
                            string Name,
                            decimal Rate,
                            RecordStatusEnum RecordStatus,
                            DateTime CreateDate,
                            string CreatorUserId);

public record CreateCurrencyModel(string Name, decimal Rate);
public record UpdateCurrencyModel(int Id, string Name, decimal Rate);
public record DeleteCurrencyModel(int Id);
