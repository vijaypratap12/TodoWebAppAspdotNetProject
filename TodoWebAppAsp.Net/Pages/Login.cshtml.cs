using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Pages
{

    public class LoginModel : PageModel
    {
        TodoConnectionDbContext db;
        public LoginModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }

        public SignupProperty signupProperty { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost(string _Email, string _Password)
        {
            SignupProperty stp = db.SignupDetailTodos.FirstOrDefault(p => p.Email == _Email);


            if (stp.Password == _Password)
            {
                string email = Request.Form["_Email"];
                string url = "./SchoolTodo/Index?_Email= " + email;
                // Response.Redirect(url);
                return Redirect(url);
            }

            else
                return Redirect("/error");

            // return Page();
        }
    }
}
