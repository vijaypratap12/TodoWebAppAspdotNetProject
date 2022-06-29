using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Pages.HomeTodo
{
    public class AddHomeTodoModel : PageModel
    {
        TodoConnectionDbContext db;
        public AddHomeTodoModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }

        [BindProperty]
        public HomeTodoProperty homeTodoProperty { set; get; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            db.HomeTodos.Add(homeTodoProperty);
            db.SaveChanges();
            return Redirect("/hometodo/index");
        }
    }
}
