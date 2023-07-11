using SharpShop.Data;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();
/*
 * The T is a type parameter and in this case can be anything (a constraint may be specified, but here there is no constraint). 
 * Without this feature you would have to declare the method for every type you plan to use:
 * 
 * static void Foo(params int[] x)    
 * static void Foo(params string[] x)    
 * static void Foo(params Customer[] x) 
*/
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*
 * Id is an optional route, controller and action are not optional.
 * If they are not definded, they will be automatically assigned to a default value.
*/

app.Run();
