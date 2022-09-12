using CadastroDeVeiculosEtec.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvcConfiguration();

builder.Services.RegisterDependences();

builder.Services.AddDatabaseConfiguarations(builder.Configuration);

var app = builder.Build();

app.UseMvcConfiguration();

app.Run();
