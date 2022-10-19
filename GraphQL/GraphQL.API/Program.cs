using GraphQL.API.Schema;

var builder = WebApplication.CreateBuilder(args);

//Register Services
builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

//Initialize Services

app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapGraphQL();
});

app.MapGet("/", () => "GraqhQL API v0.1.0");

app.Run();