using MediatR;

namespace People.Application.Features.GetAPerson;

public class GetPersonByFingerPrintQuery : IRequest<PersonDto>
{
    public Guid FingerPrint { get; set; }
}