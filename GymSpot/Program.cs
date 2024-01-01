using GymSpot.Areas.Client.Repository;
using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Areas.Client.Services;
using GymSpot.Areas.PT.ServiceContracts;
using GymSpot.Areas.PT.Services;
using GymSpot.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddSingleton<IDiaryService, DiaryService>();
builder.Services.AddSingleton<IExerciseItemService, ExerciseItemService>();
builder.Services.AddSingleton<IExerciseListService, ExerciseListService>();
builder.Services.AddSingleton<IExerciseSessionService, ExerciseSessionService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.UseEndpoints(endpoints =>
{
    //endpoints.MapControllerRoute(
    //name: "deault",
    //pattern: "{area:exists}/{controller=Home}/{action=Index}");
    //endpoints.MapControllerRoute(
    //name: "default",
    //pattern: "{controller=Login}/{action=Index}/{id?}"
    endpoints.MapControllerRoute(
    name: "deault",
    pattern: "{area=Client}/{controller=Home}/{action=Index}");
});


app.Run();
