using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoWebAppAsp.Net.Data;
using TodoWebAppAsp.Net.Model;
using TodoWebAppAsp.Net.Pages;

namespace TodoWebAppAsp.Net.Pages.SchoolTodo
{
    public class AddSchoolTodoModel : PageModel
    {
        TodoConnectionDbContext db;
        public AddSchoolTodoModel(TodoConnectionDbContext _db)
        {
            db = _db;
        }
        public string email;
        public void OnGet(string Email)
        {
            email = Email;
        }

        [BindProperty]
        public SchoolTodoProperty schoolTodo { get; set; }
        public IActionResult OnPost(string UserEmail)
        {
            // db.SchoolTodos.FirstOrDefault(p => p.UserEmail == email);
            db.SchoolTodos.Add(schoolTodo);
            db.SaveChanges();


            //string email = Request.Form["_Email"];
            string url = "./Index?_Email=" + UserEmail;
            // Response.Redirect(url);
            return Redirect(url);
            // return Redirect("/SchoolTodo/Index");
        }
    }
}
