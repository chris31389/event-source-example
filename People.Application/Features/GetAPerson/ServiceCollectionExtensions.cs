using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace People.Application.Features.GetAPerson;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddGetAPersonFeature(this IServiceCollection services) => services
        .AddMediatR(typeof(GetPersonByFingerPrintQueryHandler));
}