
using Microsoft.EntityFrameworkCore;
using static OrderService.Models.Orderrcontext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllers()
    .ConfigureApplicationPartManager(manager =>
    {
        var assembly = manager.ApplicationParts
            .FirstOrDefault(part =>
                part.Name == "ProductService");

        if (assembly != null)
        {
            manager.ApplicationParts.Remove(assembly);
        }
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddHttpClient();

builder.Services.AddDbContext<OrderrContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("con")
    ));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
