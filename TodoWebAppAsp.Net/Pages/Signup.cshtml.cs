using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Pages
{
    public class SignupModel : PageModel
    {
        TodoConnectionDbContext db;
        public SignupModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }

        [BindProperty]
        public SignupProperty signupProperty { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            db.SignupDetailTodos.Add(signupProperty);
            db.SaveChanges();
            return Redirect("login");

        }
    }
}
