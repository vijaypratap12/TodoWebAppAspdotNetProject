using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Pages.HomeTodo
{
    public class EditHomeTodoModel : PageModel
    {
        TodoConnectionDbContext db;
        public EditHomeTodoModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }

        public HomeTodoProperty homeTodoProperty { get; set; }
        public void OnGet(int? id)
        {
            homeTodoProperty = db.HomeTodos.FirstOrDefault(p => p.Id == id);
        }
        public IActionResult OnPost(int _Id, string _Title, string _Description)
        {
            HomeTodoProperty htp = db.HomeTodos.FirstOrDefault(p => p.Id == _Id);
            htp.Title = _Title;
            htp.Description = _Description;

            db.SaveChanges();
            return Redirect("/hometodo/index");
        }
    }
}
