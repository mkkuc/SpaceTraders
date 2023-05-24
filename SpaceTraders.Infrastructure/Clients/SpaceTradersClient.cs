using SpaceTraders.Application.Clients;
using SpaceTraders.Application.Register.Commands;
using System.Net.Http.Json;

namespace SpaceTraders.Infrastructure.Clients;

public class SpaceTradersClient : ISpaceTradersClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private const string _registerUrl = "https://api.spacetraders.io/v2/register";

    public SpaceTradersClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<object> RegisterAgentAsync(RegisterAgentCommand command)
    {
        var client = _httpClientFactory.CreateClient();
        return await client.PostAsJsonAsync<object>(_registerUrl, command);
    }
}

