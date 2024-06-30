using Infra.ContextBase;
using Infra.Repository;
using Model.Interface;
using Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Default")!;
builder.Services.AddTransient(_ => new DapperContext(connectionString));

builder.Services.AddTransient<IPublicacaoService, PublicacaoService>();
builder.Services.AddTransient<IPublicacaoRepository, PublicacaoRepository>();

builder.Services.AddTransient<IForumService, ForumService>();
builder.Services.AddTransient<IForumRepository, ForumRepository>();

builder.Services.AddTransient<IRespostaForumService, RespostaForumService>();
builder.Services.AddTransient<IRespostaForumRepository, RespostaForumRepository>();

var app = builder.Build();

app.UseCors("AllowAll");

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();