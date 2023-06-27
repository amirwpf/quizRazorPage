using ClassLibrary_razor_temp.Models;

namespace ClassLibrary_razor_temp.Services
{
	public interface IUserRepository
	{
		IEnumerable<User> GetAllUsers();
		User GetUser(int id);
	}
}