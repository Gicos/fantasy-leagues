namespace FL.Model.Domain;

public class Permission {
	public Guid Id { get; init; }
	public string Name { get; init; }
	public string DisplayName { get; init; }
	
	public Permission(Guid Id, 
		string Name, 
		string DisplayName) {
		this.Id = Id;
		this.Name = Name;
		this.DisplayName = DisplayName;
	}
}