using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.


builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                                                                     .EnableDetailedErrors()
                                                                     .EnableSensitiveDataLogging()
                                                                     .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));



builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserUnit, UserUnit>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductUnit, ProductUnit>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
