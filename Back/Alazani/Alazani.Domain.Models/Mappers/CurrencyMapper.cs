using Alazani.Domain.Entities;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Models.Domain;

namespace Alazani.Domain.Models.Mappers;

public static class CurrencyMapper
{
    public static CurrencyModel ToModel(this Currency entity)
    {
        return new CurrencyModel(entity.Id,
                                 entity.Name,               
                                 entity.Rate,               
                                 entity.RecordStatus,               
                                 entity.CreateDate,               
                                 entity.CreateUserId);               
    }

    public static Currency ToEntity(this CreateCurrencyModel model)
    {
        return new Currency
        {
            Name = model.Name,
            Rate = model.Rate,
            RecordStatus = RecordStatusEnum.Active,
            CreateDate = DateTimeOffset.Now,
            CreateUserId = "Test"
        };
    }

    public static Currency ToEntity(this UpdateCurrencyModel model, Currency currency)
    {

        currency.Name = model.Name;
        currency.Rate = model.Rate;

        return currency;
    }

}
