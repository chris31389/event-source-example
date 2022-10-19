using MediatR;

namespace People.Application.Features.GetAPerson;

public class GetPersonByFingerPrintQueryHandler : IRequestHandler<GetPersonByFingerPrintQuery, PersonDto>
{
    public Task<PersonDto> Handle(GetPersonByFingerPrintQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new PersonDto());
    }
}