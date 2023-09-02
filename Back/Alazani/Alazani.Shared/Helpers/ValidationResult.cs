using System.Net;

namespace Alazani.Shared.Helpers;

public sealed class ValidationResult : ApiResponse, IValidationResult
{

    public ValidationResult(Error[] errors)
            : base(HttpStatusCode.InternalServerError,
                   errors.Select(x => new KeyValuePair<string, string?>(x.Code, x.Description)))
    {
        Errors = errors;
    }
    public Error[] Errors { get; }

    public static ValidationResult WithErrors(Error[] errors) => new(errors);
}


public sealed class ValidationResult<TValue> : ApiResponse<TValue>, IValidationResult
{

    public ValidationResult(Error[] errors)
            : base(default, HttpStatusCode.InternalServerError,
                   errors.Select(x => new KeyValuePair<string, string?>(x.Code, x.Description)))
    {
        Errors = errors;
    }
    public Error[] Errors { get; }

    public static ValidationResult<TValue> WithErrors(Error[] errors) => new(errors);
}



