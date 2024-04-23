using Projeto_Triade.Abstraction.Interfaces.Repository;
using Projeto_Triade.Abstraction.Interfaces.Service;
using Projeto_Triade.Infrastructure.Repository;
using Projeto_Triade.Model.ValueObjects;
using Projeto_Triade.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton(new ConfigurationVO
{
    ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection")
});


// Injeção de dependencia 
builder.Services.AddScoped<IRelatorioService, RelaorioService>();
builder.Services.AddScoped<IRelatorioRepository, RelatorioRepository>();

builder.Services.AddScoped<IRequisicaoService, RequisicaoService>();
builder.Services.AddScoped<IRequisicaoRepository, RequisicaoRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
