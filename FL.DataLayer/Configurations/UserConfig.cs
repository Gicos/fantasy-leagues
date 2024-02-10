using FL.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FL.DataLayer.Configurations;

internal class UserConfig : IEntityTypeConfiguration<User> {
	public void Configure(EntityTypeBuilder<User> builder) {
		builder.HasKey(e => e.Id);
		
		builder.Property(e => e.DisplayName)
			.HasMaxLength(128)
			.IsRequired();
		
		builder.Property(e => e.Email)
			.HasMaxLength(128)
			.IsRequired();
		
		builder.Property(e => e.Password)
			.HasMaxLength(128)
			.IsRequired();
		
		builder.Property(e => e.Enabled)
			.IsRequired();
		
		builder.Property(e => e.Activated)
			.IsRequired();
		
		builder.Property(e => e.CreationTime)
			.IsRequired();
		
		builder.Property(e => e.LastUpdateTime)
			.IsRequired();
		
		builder.HasMany(e => e.Roles)
			.WithMany()
			.UsingEntity(j => j.ToTable("UserRoles"));
	}
}