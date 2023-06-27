using ClassLibrary_razor_temp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_razor_temp.Services
{
	public class MockUserRepository : IUserRepository
	{
		private List<User> _employees;
		public MockUserRepository()
		{
			_employees = new List<User>()
			{
				new User{ Id = 1,Name="emp1",Department=Dept.IT,Email="emp1@gmail.com",PhotoPath="emp1.png"},
				new User { Id = 2, Name = "emp2", Department = Dept.HR, Email = "emp2@gmail.com", PhotoPath = "emp2.jpg" },
				new User{ Id = 3,Name="emp3",Department=Dept.Payroll,Email="emp3@gmail.com"}
			};
		}
		public IEnumerable<User> GetAllUsers()
		{
			return _employees;
		}

		public User GetUser(int id)
		{
			return _employees.FirstOrDefault<User>(p=>p.Id==id);
		}
	}
}
