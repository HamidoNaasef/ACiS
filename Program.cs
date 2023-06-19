using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using ACiS.Models.Repository;
using ACiS.Models;
using ACiS.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc();
builder.Services.AddScoped<IRepository<User>, UserDBRepository>();
builder.Services.AddScoped<IRepository<Department>, DepartmentRepo>();
builder.Services.AddScoped<IRepository<Division>, DivisionRepo>();
builder.Services.AddScoped<IRepository<Subject>, SubjectRepo>();
builder.Services.AddScoped<IRepository<GradingCriteria>, GradingRepo>();
builder.Services.AddScoped<IRepository<Authority>, AuthorietyRepo>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options => 
{
    options.IdleTimeout = TimeSpan.FromMinutes(120);
});
//what is the wrong here??
builder.Services.AddDbContext<ApplicationDBContext>();


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

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Login}/{id?}");

//RunMigration(app);


app.Run();
/*
void RunMigration(WebApplication webHost)
{
    using (var scope = webHost.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
        db.Database.Migrate();
    };
}*/



