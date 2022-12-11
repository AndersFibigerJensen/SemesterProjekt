using SemesterProjekt;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IBoatRepository, JsonboatRepository>();
builder.Services.AddTransient<IClubMemberRepository, JsonClubMemberRepository>();
builder.Services.AddTransient<IRentalSchedule, JsonIRentalSchedule>();
builder.Services.AddTransient<IEventRepository, JsonEventRepository>();
builder.Services.AddTransient<IBlogRepository, JsonBlogRepository>();
builder.Services.AddSingleton<LoginService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
