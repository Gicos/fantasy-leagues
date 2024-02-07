namespace FL.Model.Domain;

public record Permission(
	Guid Id, 
	string Name, 
	string DisplayName);