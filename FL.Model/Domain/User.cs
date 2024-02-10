namespace FL.Model.Domain;

public class User {
	public Guid Id { get; init; }
	public string DisplayName { get; init; }
	public string Email { get; init; }
	public string Password { get; init; }
	public bool Enabled { get; init; }
	public bool Activated { get; init; }
	public DateTime CreationTime { get; init; }
	public DateTime LastUpdateTime { get; init; }
	public virtual ICollection<Role>? Roles { get; init; }

	public User(Guid Id,
		string DisplayName,
		string Email,
		string Password,
		bool Enabled,
		bool Activated,
		DateTime CreationTime,
		DateTime LastUpdateTime) {
		this.Id = Id;
		this.DisplayName = DisplayName;
		this.Email = Email;
		this.Password = Password;
		this.Enabled = Enabled;
		this.Activated = Activated;
		this.CreationTime = CreationTime;
		this.LastUpdateTime = LastUpdateTime;
	}
}