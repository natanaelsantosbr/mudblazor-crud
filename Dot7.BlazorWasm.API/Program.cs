using Dot7.BlazorWasm.API.Data;
using Dot7.BlazorWasm.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(a =>
{
    a.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<ISuperHeroesService, SuperHeroesService>();

builder.Services.AddCors(a =>
{
    a.AddPolicy(name: "blazorCors",
        policy =>
        {
            policy.WithOrigins("https://localhost:7279")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("blazorCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
