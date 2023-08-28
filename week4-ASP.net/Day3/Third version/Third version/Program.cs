using Third_version.BLL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IStudent,StudentBLL>();
builder.Services.AddSession();


var app = builder.Build();

//----------------Start middle ware---------------------------

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("First\n");
//    await next.Invoke();
//});
//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello,Welcome");
//});


//----------------End middle ware----------------------------


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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}");

app.Run();
