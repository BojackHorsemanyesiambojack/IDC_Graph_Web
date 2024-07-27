using IDC_Web.Services;
using IDC_Web.Shared.Context;
using IDC_Web.Utils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string StringConnection = DatabaseUtils.GetDataBaseStringConnection();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<CatalogueService>();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(StringConnection)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.UseAuthorization();
app.UseEndpoints(Endpoints =>
{
    Endpoints.MapGet("/", context =>
    {
        context.Response.Redirect("/index.html");
        return Task.CompletedTask;
    });
});
app.MapRazorPages();

app.Run();
