using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Pages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Pages.SchoolTodo
{
    public class IndexModel : PageModel
    {
        TodoConnectionDbContext db;
        public IndexModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }

        public List<SchoolTodoProperty> schoolTodos { get; set; }
        public string email;
        public void OnGet(string _Email)
        {
            email = _Email;
            schoolTodos = db.SchoolTodos.Where(p => p.UserEmail == _Email).ToList();
        }

    }
}
