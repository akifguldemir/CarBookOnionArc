using CarBookApplication.Features.Mediator.Queries.CarFeatureQueries;
using CarBookApplication.Features.Mediator.Results.CarFeatureResults;
using CarBookApplication.Interfaces.CarFeatureInterfaces;
using MediatR;

namespace CarBookApplication.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly ICarFeatureRepository _repository;

        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarFeaturesByCarId(request.Id);
            return values.Select(x => new GetCarFeatureByCarIdQueryResult
            {
               Available = x.Available,
               CarFeatureID = x.CarFeatureID,
               FeatureID = x.CarFeatureID,
               
            }).ToList();
        }
    }
}
