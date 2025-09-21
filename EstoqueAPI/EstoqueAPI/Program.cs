using EstoqueAPI.Services;
using Microsoft.OpenApi.Models;
using NHibernate;
using NHibernate.Cfg;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "EstoqueAPI",
        Version = "v1"
    });

    c.EnableAnnotations();
});

builder.Services.AddSingleton<ISessionFactory>((s) =>
{
    var sessionFactory = new Configuration().Configure().BuildSessionFactory();
    return sessionFactory;
});

builder.Services.AddTransient<ProductService>();

builder.Services.AddAuthorization();
builder.Services.AddCors(
    b => b.AddDefaultPolicy(c =>
        c.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()
    )
);
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
