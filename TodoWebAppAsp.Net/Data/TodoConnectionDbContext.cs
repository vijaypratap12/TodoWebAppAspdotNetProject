using Microsoft.EntityFrameworkCore;
using TodoWebAppAsp.Net.Model;

namespace TodoWebAppAsp.Net.Data
{
    public class TodoConnectionDbContext : DbContext
    {
        public TodoConnectionDbContext(DbContextOptions<TodoConnectionDbContext> options) : base(options)
        {

        }

        public DbSet<SchoolTodoProperty> SchoolTodos { get; set; }
        public DbSet<HomeTodoProperty> HomeTodos { get; set; }
        public DbSet<SignupProperty> SignupDetailTodos { get; set; }
    }
}
