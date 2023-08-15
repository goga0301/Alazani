namespace Alazani.Shared.Helpers;

public interface IValidationResult
{
    public static readonly Error ValidationError = new("Validation Error","A validation problem occured");

    Error[] Errors { get; }
}
