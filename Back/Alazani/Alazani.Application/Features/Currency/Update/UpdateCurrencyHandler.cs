namespace Alazani.Application.Features.Currency.Update;

public class UpdateCurrencyHandler : IRequestHandler<UpdateCurrencyCommand, IApiResponse<bool>>
{
    private readonly ICurrencyRepository _currencyRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCurrencyHandler(ICurrencyRepository currencyRepository, IUnitOfWork unitOfWork)
    {
        _currencyRepository = currencyRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IApiResponse<bool>> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var currency = await _currencyRepository.GetSingleAsync(x => x.Id == request.Model.Id);

        if (currency == null)
        {
            throw new CurrencyNotFoundException($"Currency by ID: {request.Model.Id} not found");
        }

        var entity = request.Model.ToEntity(currency);
        _currencyRepository.Update(entity);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return ApiResponse<bool>.Success(true, "Currency Updated Succesfully");
    }
}
