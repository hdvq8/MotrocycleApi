using Microsoft.AspNetCore.HttpOverrides;
using MotorcycleCompany.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.Configuremysqlcontext(builder.Configuration);
builder.Services.AddControllers().AddApplicationPart(typeof(MotorcycleCompany.Presentation.AssemblyReference).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseForwardedHeaders(new ForwardedHeadersOptions()
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();


app.MapControllers();

app.Run();
