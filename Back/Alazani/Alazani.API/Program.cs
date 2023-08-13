using Alazani.API.Middlewares;
using Alazani.API.Options;
using Alazani.Infrastructure.Repository;
using Alazani.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLogging();

builder.Services.AddDbContexts(builder.Configuration);
builder.Services.AddDomainServices();
builder.Services.AddRepositories();


builder.Services.AddTransient<GlobalExceptionHandlingMiddleware>();

builder.Services.ConfigureOptions<DatabaseOptionsSetup>();

builder.Services.AddOptions<DatabaseOptions>()
    .BindConfiguration(nameof(DatabaseOptions))
    .ValidateDataAnnotations()
    .ValidateOnStart();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Services.MigrateDatabase();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
