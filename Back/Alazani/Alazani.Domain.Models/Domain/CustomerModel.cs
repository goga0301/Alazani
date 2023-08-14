using Alazani.Domain.Entities.Enums;

namespace Alazani.Domain.Models.Domain;

public record CustomerModel(int Id,
                            string FirstName,
                            string LastName,
                            string EmailAddress,
                            string PhoneNumber,
                            string Password,
                            RecordStatusEnum RecordStatus,
                            DateTimeOffset CreateDate,
                            string CreatorUserId);

public record CreateCustomerModel(string FirstName,
                                  string LastName,
                                  string EmailAddress,
                                  string PhoneNumber,
                                  string Password);
public record UpdateCustomerModel(int Id,
                                  string FirstName,
                                  string LastName,
                                  string EmailAddress,
                                  string PhoneNumber,
                                  string Password);
public record DeleteCustomerModel(int Id);
