using Alazani.Domain.Entities;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Models.Domain;

namespace Alazani.Domain.Models.Mappers;

public static class CustomerMapper
{
    public static CustomerModel ToModel(this Customer entity)
    {
        return new CustomerModel(entity.Id,
                                 entity.FirstName,                              
                                 entity.LastName,                              
                                 entity.EmailAddress,                              
                                 entity.PhoneNumber,  
                                 entity.Password,
                                 entity.RecordStatus,
                                 entity.CreateDate,                              
                                 entity.CreateUserId);                                         
    }

    public static Customer ToEntity(this CreateCustomerModel model)
    {
        return new Customer
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            EmailAddress = model.EmailAddress,
            PhoneNumber = model.PhoneNumber,
            Password = model.Password,
            RecordStatus = RecordStatusEnum.Active,
            CreateDate = DateTimeOffset.Now,
            CreateUserId = "Test"
        };
    }

    public static Customer ToEntity(this UpdateCustomerModel model, Customer customer)
    {

        customer.FirstName = model.FirstName;
        customer.LastName = model.LastName;
        customer.EmailAddress = model.EmailAddress;
        customer.PhoneNumber = model.PhoneNumber;
        customer.Password = model.Password;

        return customer;
    }

}
