using MediatR;

namespace SpaceTraders.Application.Register.Commands;

public sealed record RegisterAgentCommand(string Symbol, string Faction) : IRequest<object>;
