using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWeb.Data;
using SalesWebMvc.Data;

#nullable disable

var builder = WebApplication.CreateBuilder(args);

// Configurar o contexto do banco de dados
builder.Services.AddDbContext<SalesWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SalesWebContext") ?? throw new InvalidOperationException("Connection string 'SalesWebContext' not found.")));

// Add services to the container.
// Registrando o serviço de semeadura
builder.Services.AddScoped<SeedingService>();

// Adicionar controladores e visualizações aos serviços
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Executar a semeadura de dados se for ambiente de desenvolvimento.
if (app.Environment.IsDevelopment())
    {

    using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope())
    {
        var seedService = serviceScope.ServiceProvider.GetRequiredService<SeedingService>();
        seedService.Seed();
    }
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
