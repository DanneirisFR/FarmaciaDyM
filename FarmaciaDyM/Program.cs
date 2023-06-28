using FarmaciaDyM.Data;
using FarmaciaDyM.Data.Context;
using FarmaciaDyM.Data.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddScoped<IMyDbContext, MyDbContext>();
builder.Services.AddScoped<IClienteServicescs, ClienteServicescs>();
builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();
builder.Services.AddScoped<IProductoServices, ProductoServices>();
builder.Services.AddScoped<IProveedorServices, ProveedorServices>();
builder.Services.AddScoped<IVentaServices, VentaServices>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
