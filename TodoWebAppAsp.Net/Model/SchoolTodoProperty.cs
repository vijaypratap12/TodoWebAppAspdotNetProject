namespace TodoWebAppAsp.Net.Model
{
    public class SchoolTodoProperty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserEmail { set; get; }

        public DateTime LastModified { get; set; } = DateTime.Now;
    }
}
