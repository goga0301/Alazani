namespace Alazani.Application.Features.Currency.Create;

public class CreateCurrencyHandler : IRequestHandler<CreateCurrencyCommand, IApiResponse<int>>
{
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCurrencyHandler(ICurrencyRepository currencyRepository, IUnitOfWork unitOfWork)
    {
        _currencyRepository = currencyRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IApiResponse<int>> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var entity = request.Model.ToEntity();

        await _currencyRepository.CreateAsync(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResponse<int>.Success(entity.Id, "Currency Created Successfully");
    }
}
