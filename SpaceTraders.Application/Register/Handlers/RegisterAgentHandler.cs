using MediatR;
using SpaceTraders.Application.Clients;
using SpaceTraders.Application.Register.Commands;

namespace SpaceTraders.Api.Handlers;

public class RegisterAgentHandler : IRequestHandler<RegisterAgentCommand, object>
{
    private readonly ISpaceTradersClient _spaceTradersClient;

    public RegisterAgentHandler(ISpaceTradersClient spaceTradersClient)
    {
        _spaceTradersClient = spaceTradersClient;
    }

    public async Task<object> Handle(RegisterAgentCommand command, CancellationToken cancellationToken)
    {
        if (command == null || command.Symbol == null || command.Faction == null)
        {
            return new object();
        }
        
        var result = await _spaceTradersClient.RegisterAgentAsync(command);
        return result;
    }
}

