using FL.Interfaces.Repositories;
using FL.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace FL.DataLayer.Repositories;

internal class UsersRepository : IUsersRepository {
	private readonly FLDbContext _context;
	
	public UsersRepository(FLDbContext context) {
		_context = context;
	}
	
	public async Task<List<User>> GetUsers() {
		return await _context.Users.ToListAsync();
	}
}