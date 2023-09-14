namespace Alazani.Application.Features.Currency.Delete;

public class DeleteCurrencyHandler : IRequestHandler<DeleteCurrencyCommand, IApiResponse<bool>>
{
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCurrencyHandler(ICurrencyRepository currencyRepository, IUnitOfWork unitOfWork)
    {
        _currencyRepository = currencyRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IApiResponse<bool>> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
    {
        var currency = await _currencyRepository.GetSingleAsync(x => x.Id == request.Id);
        if (currency == null)
        {
            throw new Exception($"Currency by ID:{request.Id} Not Found");
        }

        return ApiResponse<bool>.Success(true, "Currency Deleted Successfully");
    }
}