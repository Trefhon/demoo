var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

// Добавляем конкретные маршруты для лучшей навигации
app.MapGet("/", () => Results.Redirect("/Index"));
app.MapGet("/home", () => Results.Redirect("/Index"));

app.Run();