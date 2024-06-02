using Infra.ContextBase;
using Infra.Repository;
using Model.Interface;
using Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://127.0.0.1:5500")); // Substitua pelo seu domínio frontend
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Default")!;
builder.Services.AddTransient(_ => new DapperContext(connectionString));
builder.Services.AddTransient<IPublicacaoRepository, PublicacaoRepository>();
builder.Services.AddTransient<IPublicacaoService, PublicacaoService>();

var app = builder.Build();

app.UseCors("AllowOrigin");

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();