using FL.Commons.Configurations;
using FL.DataLayer;
using FL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FL.Service;

public class Program {
	public static void Main(string[] args) {
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddAuthentication();
		builder.Services.AddAuthorization();

		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		ConnectionStrings? connectionStrings = builder.Configuration.GetRequiredSection("ConnectionStrings").Get<ConnectionStrings>();
		if(connectionStrings is null) {
			throw new ArgumentNullException(nameof(connectionStrings));
		}
		
		builder.Services.AddFLDbContext(connectionStrings.DefaultConnection);
		builder.Services.AddRepositories();
		
		var app = builder.Build();

		
		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment()) {
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		// app.UseHttpsRedirection();

		app.UseAuthentication();
		app.UseAuthorization();

		app.MapGet("/users", (IUsersRepository repo) => repo.GetUsers());
		
		app.Run();
	}
}