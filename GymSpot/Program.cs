using GymSpot.Areas.Client.ServiceContracts;
using GymSpot.Areas.Client.Services;
using GymSpot.Areas.PT.ServiceContracts;
using GymSpot.Areas.PT.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IDiaryService, DiaryService>();
builder.Services.AddSingleton<IExerciseItemService, ExerciseItemService>();
builder.Services.AddSingleton<IExerciseListService, ExerciseListService>();
builder.Services.AddSingleton<IExerciseSessionService, ExerciseSessionService>();

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
    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}");
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}"
    );
});


app.Run();
