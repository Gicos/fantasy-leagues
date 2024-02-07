using FL.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FL.DataLayer.Configurations;

internal class PermissionConfig : IEntityTypeConfiguration<Permission> {
	public void Configure(EntityTypeBuilder<Permission> builder) {
		builder.HasKey(e => e.Id);

		builder.Property(e => e.DisplayName)
			.HasMaxLength(128)
			.IsRequired();

		builder.Property(e => e.Name)
			.HasMaxLength(128)
			.IsRequired();
	}
}