using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Pages.HomeTodo
{
    public class IndexModel : PageModel
    {
        TodoConnectionDbContext db;
        public IndexModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }
        public List<HomeTodoProperty> homeTodoProperty { get; set; }
        public void OnGet()
        {
            homeTodoProperty = db.HomeTodos.ToList();
        }

    }
}
