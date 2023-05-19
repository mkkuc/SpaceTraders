using MediatR;
using SpaceTraders.Application.DTO;

namespace SpaceTraders.Api.Handlers;

public class RegisterAgentHandler : IRequestHandler<RegisterAgentRequest, IResult>
{
    public async Task<IResult> Handle(RegisterAgentRequest request, CancellationToken cancellationToken)
    {
        return await (Task<IResult>)Results.Created("", new RegisterAgentDto("", ""));
    }
}

