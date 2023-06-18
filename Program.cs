using CardGame.Database;
using CardGame.Domain.Repositories;
using CardGame.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ContainerConnection");
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseNpgsql(connectionString)
);

//Dependency injection registration for repos
//TODO refactor into separate class
builder.Services.AddScoped<IDeckRepository, DeckRepository>();
builder.Services.AddScoped<IPileRepository, PileRepository>();
builder.Services.AddScoped<ICardRepository, CardRepository>();

//Add automapper
//TODO replace automapper with explicit ToModel/FromModel extension methods
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

DatabaseConfig.Initialize(app);

app.Run();
