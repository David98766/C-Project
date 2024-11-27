using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IS4439_Project_1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using IS4439_Project_1.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using IS4439_Project_1.Services;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<IS4439_Project_1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IS4439_Project_1Context") ?? throw new InvalidOperationException("Connection string 'IS4439_Project_1Context' not found.")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
})
    .AddEntityFrameworkStores<IS4439_Project_1Context>()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender, DummyEmailSender>();

builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStatusCodePagesWithRedirects("/Error/{0}");// placeholder for whatever error it is 400, 404 etc.

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Configuring degault route to naivgate to the store

app.MapControllerRoute(
    name: "Store Page",
    pattern: "StorePage",
    defaults: new { controller = "Product", action = "Store" });

// Configuring degault route to naivgate to the Add Product Page

app.MapControllerRoute(
    name: "addProduct",
    pattern: "AddProduct",
    defaults: new { controller = "Product", action = "Add" });



app.MapRazorPages();


app.Run();
