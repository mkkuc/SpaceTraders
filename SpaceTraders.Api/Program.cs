using MediatR;
using SpaceTraders.Api.Handlers;
using SpaceTraders.Application.Register.Commands;
using SpaceTraders.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(
    typeof(RegisterAgentHandler).Assembly,
    typeof(RegisterAgentCommand).Assembly
    ));

var app = builder.Build();

app.MapPost("/api/registerAgent", async (IMediator mediator, RegisterAgentCommand command) =>
{
    var result = await mediator.Send(command);
    return Results.CreatedAtRoute("Register a new agent in the game", result) ;
})
    .WithName("Register agent")
    .Produces(StatusCodes.Status201Created);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
