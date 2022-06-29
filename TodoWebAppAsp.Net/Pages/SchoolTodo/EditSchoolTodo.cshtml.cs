using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Pages.SchoolTodo
{
    public class EditSchoolTodoModel : PageModel
    {
        TodoConnectionDbContext db;

        public EditSchoolTodoModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }

        public SchoolTodoProperty schoolTodo { get; set; }
        public void OnGet(int? id)
        {
            schoolTodo = db.SchoolTodos.FirstOrDefault(p => p.Id == id);
        }

        public IActionResult OnPost(int _Id, string _Title, string _Description, string UserEmail)
        {
            SchoolTodoProperty stp = db.SchoolTodos.FirstOrDefault(p => p.Id == _Id);
            stp.Title = _Title;
            stp.Description = _Description;

            db.SaveChanges();
            string url = "./Index?_Email=" + UserEmail;
            return Redirect(url);
        }
    }
}
