using SpaceTraders.Application.Register.Commands;

namespace SpaceTraders.Application.Clients;
public interface ISpaceTradersClient
{
    Task<object> RegisterAgentAsync(RegisterAgentCommand command);
}
