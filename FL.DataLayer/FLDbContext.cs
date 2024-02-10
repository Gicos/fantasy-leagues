using FL.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace FL.DataLayer;

internal class FLDbContext : DbContext {
	public virtual DbSet<Permission> Permissions { get; set; }
	public virtual DbSet<Role> Roles { get; set; }
	public virtual DbSet<User> Users { get; set; }

	public FLDbContext(DbContextOptions<FLDbContext> options) : base(options) { }
	
	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(
			typeof(FLDbContext).Assembly
		);
	}
}