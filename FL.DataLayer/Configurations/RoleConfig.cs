using FL.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FL.DataLayer.Configurations;

internal class RoleConfig : IEntityTypeConfiguration<Role> {
	public void Configure(EntityTypeBuilder<Role> builder) {
		builder.HasKey(e => e.Id);

		builder.Property(e => e.DisplayName)
			.HasMaxLength(128)
			.IsRequired();

		builder.Property(e => e.Name)
			.HasMaxLength(128)
			.IsRequired();

		builder.Property(e => e.CreationTime)
			.IsRequired();

		builder.Property(e => e.LastUpdateTime)
			.IsRequired();

		builder.HasMany(e => e.Permissions)
			.WithMany()
			.UsingEntity(j => j.ToTable("RolesPermissions"));
	}
}