using FL.Model.Domain;

namespace FL.Interfaces.Repositories;

public interface IUsersRepository {
	Task<List<User>> GetUsers();
}