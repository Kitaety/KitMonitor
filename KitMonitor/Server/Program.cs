using FluentValidation;
using KitMonitor.Server.ActionFilters.Company;
using KitMonitor.Server.AutoMappers;
using KitMonitor.Server.Extensions;
using KitMonitor.Server.Models.Database;
using KitMonitor.Server.Repositories;
using KitMonitor.Server.Repositories.Interfaces;
using KitMonitor.Server.Services;
using KitMonitor.Server.Services.Interfaces;
using KitMonitor.Server.Validators.Company;
using KitMonitor.Server.Validators.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KitMonitor.Server
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Disable localization of validation error messages
			ValidatorOptions.Global.LanguageManager.Enabled = false;

			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();

			builder.Services.AddDbContext<DatabaseContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

			builder.Services.AddScoped<CreateCompanyValidator>();
			builder.Services.AddScoped<UpdateCompanyValidator>();
			builder.Services.AddScoped<ICompanyValidator, CompanyValidator>();

			builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();

			builder.Services.AddTransient<ICompanyService, CompanyService>();

			builder.Services.AddAutoMapper(typeof(CompanyAutoMapperProfile));

			builder.Services.AddSwaggerGen();
			builder.Services.AddScoped<CreateCompanyValidationFilter>();
			builder.Services.AddScoped<UpdateCompanyValidationFilter>();

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

			app.UseSwagger();
			app.UseSwaggerUI();

			app.UseGlobalExceptionHandling();
			app.UseDatabaseTransaction();

			app.MapRazorPages();
			app.MapControllers();
			app.MapFallbackToFile("index.html");

			app.Run();
		}
	}
}