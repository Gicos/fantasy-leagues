using FL.DataLayer;
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

		builder.Services.AddDbContext<FLDbContext>(options => {
			options.UseSqlServer("");
		});
		
		var app = builder.Build();

		
		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment()) {
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		// app.UseHttpsRedirection();

		app.UseAuthentication();
		app.UseAuthorization();

		app.Run();
	}
}