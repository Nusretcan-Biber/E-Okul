using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MasterContext>(x => x.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_URI")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (IServiceScope serviceScope = app.Services.CreateScope())
{
    var context = serviceScope.ServiceProvider.GetService<MasterContext>();
    context.Database.Migrate();
}
// proje her build al�nd���na snapshot'a bak�p database de g�ncelleme varm� diye bak�yor e�er varsa Update-Database i�lemi, yap�yor otamadik olarak

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
