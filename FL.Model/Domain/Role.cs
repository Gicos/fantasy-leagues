namespace FL.Model.Domain;

public record Role(
	Guid Id, 
	string Name, 
	string DisplayName, 
	DateTime CreationTime, 
	DateTime LastUpdateTime,
	ICollection<Permission>? Permissions = null);