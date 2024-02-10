using FL.Commons.Configurations;
using FL.DataLayer.Repositories;
using FL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FL.DataLayer;

public static class FLServiceExtensions {
	public static IServiceCollection AddFLDbContext(this IServiceCollection service, string connectionString) {
		service.AddDbContext<FLDbContext>(options => {
			options.UseSqlServer(connectionString);
		});

		return service;
	}
	
	public static IServiceCollection AddRepositories(this IServiceCollection services) {
		services.AddScoped<IUsersRepository, UsersRepository>();	
		return services;
	}
}