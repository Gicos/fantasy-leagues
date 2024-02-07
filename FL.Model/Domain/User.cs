namespace FL.Model.Domain;

public record User(
	Guid Id, 
	string DisplayName, 
	string Email, 
	string Password,
	bool Enabled,
	bool Activated, 
	DateTime CreationTime, 
	DateTime LastUpdateTime,
	ICollection<Role>? Roles = null);