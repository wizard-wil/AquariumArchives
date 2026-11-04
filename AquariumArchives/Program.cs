using AquariumArchives.Components;
using AquariumArchives.Models;

namespace AquariumArchives
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddSingleton<DatabaseService>();
            var app = builder.Build();
            app.Services.GetRequiredService<DatabaseService>();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.MapGet("/fish-image/{id:int}", async (int id, DatabaseService db) =>
            {
                var fish = await db.GetFishImageAsync(id);
                return fish?.ImageData is { Length: > 0 }
                    ? Results.File(fish.ImageData, fish.ImageContentType)
                    : Results.NotFound();
            });

            app.Run();
        }
    }
}
