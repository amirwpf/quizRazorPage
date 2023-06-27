using ClassLibrary_razor_temp.Models;
using ClassLibrary_razor_temp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_razor_temp.Pages.User
{
    public class DetailModel : PageModel
    {
        private readonly IUserRepository _userRepository;
		public ClassLibrary_razor_temp.Models.User user { get; set; }

		public DetailModel(IUserRepository employeeRepository)
        {
              _userRepository= employeeRepository;
        }
        public void OnGet(int id)
        {
			user = _userRepository.GetUser(id);

		}
    }
}
