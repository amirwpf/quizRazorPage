using ClassLibrary_razor_temp.Models;
using ClassLibrary_razor_temp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_razor_temp.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository _employeeRepository;
        public IEnumerable<ClassLibrary_razor_temp.Models.User> Users { get; set; }
        public IndexModel(IUserRepository employeeRepository)
        {
            _employeeRepository= employeeRepository;
        }
        public void OnGet()
        {
            Users = _employeeRepository.GetAllUsers();
        }
    }
}
