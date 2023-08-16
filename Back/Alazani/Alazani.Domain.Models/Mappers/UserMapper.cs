using Alazani.Domain.Entities;
using Alazani.Domain.Entities.Enums;
using Alazani.Domain.Models.Domain;

namespace Alazani.Domain.Models.Mappers;

public static class UserMapper
{
    public static UserModel ToModel(this User entity)
    {
        return new UserModel(entity.Id,
                             entity.FirstName,
                             entity.LastName,
                             entity.EmailAddress,
                             entity.PhoneNumber,
                             entity.PrivateNumber,
                             entity.UserName,
                             entity.Password,
                             entity.Address,
                             entity.Status,
                             entity.BirthDate,
                             entity.StartDate,
                             entity.EndDate,
                             entity.OrganizationId,
                             entity.Role?.ToModel(),
                             entity.RecordStatus,
                             entity.CreateDate,
                             entity.CreateUserId);
    }

    public static User ToEntity(this CreateUserModel model)
    {
        return new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            EmailAddress = model.EmailAddress,
            PhoneNumber = model.PhoneNumber,
            PrivateNumber = model.PrivateNumebr,
            UserName = model.UserName,
            Password = model.Password,
            Address = model.Address,
            Status = model.Status,
            BirthDate = model.BirthDate,
            StartDate = model.StartDate,
            EndDate = model.EndDate,
            OrganizationId = model.OrganizationId,
            RoleId = model.RoleId,
            RecordStatus = RecordStatusEnum.Active,
            CreateDate = DateTime.UtcNow,
            CreateUserId = "Test"

        };
    }

    public static User ToEntity(this UpdateUserModel model, User user)
    {

        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.EmailAddress = model.EmailAddress;
        user.PhoneNumber = model.PhoneNumber;
        user.PrivateNumber = model.PrivateNumebr;
        user.UserName = model.UserName;
        user.Password = model.Password;
        user.Address = model.Address;
        user.Status = model.Status;
        user.BirthDate = model.BirthDate;
        user.StartDate = model.StartDate;
        user.EndDate = model.EndDate;
        user.OrganizationId = model.OrganizationId;
        user.RoleId = model.RoleId;

        return user;
    }
}
