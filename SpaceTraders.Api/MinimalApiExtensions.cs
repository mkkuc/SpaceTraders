using MediatR;
using SpaceTraders.Abstractions;

namespace SpaceTraders.Api;

public static class MinimalApiExtensions
{
    public static WebApplication MediateGet<TRequest>(
        this WebApplication app,
        string template) where TRequest : IHttpRequest
    {
        app.MapGet(template, async (IMediator mediator, TRequest request) => await mediator.Send(request));
        return app;
    }

    public static WebApplication MediatePost<TRequest>(
    this WebApplication app,
    string template) where TRequest : IHttpRequest
    {
        app.MapPost(template, async (IMediator mediator, TRequest request) => await mediator.Send(request));
        return app;
    }
}

