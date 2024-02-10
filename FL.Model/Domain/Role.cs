namespace FL.Model.Domain;

public class Role {
	public Guid Id { get; init; }
	public string Name { get; init; }
	public string DisplayName { get; init; }
	public DateTime CreationTime { get; init; }
	public DateTime LastUpdateTime { get; init; }

	public virtual ICollection<Permission> Permissions { get; init; }
	
	public Role(Guid Id, 
		string Name, 
		string DisplayName, 
		DateTime CreationTime, 
		DateTime LastUpdateTime) {
		this.Id = Id;
		this.Name = Name;
		this.DisplayName = DisplayName;
		this.CreationTime = CreationTime;
		this.LastUpdateTime = LastUpdateTime;
	}
}