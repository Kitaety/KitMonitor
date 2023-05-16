using KitMonitor.Server.Models;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

namespace KitMonitor
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);


			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();

			builder.Services.AddDbContext<DatabaseContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseRouting();


			app.MapRazorPages();
			app.MapControllers();
			app.MapFallbackToFile("index.html");

			app.Run();
		}
	}
}