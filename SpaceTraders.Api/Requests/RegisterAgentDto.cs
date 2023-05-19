using SpaceTraders.Abstractions;

namespace SpaceTraders.Application.DTO;

public sealed record RegisterAgentRequest(string Symbol, string Faction) : IHttpRequest;
