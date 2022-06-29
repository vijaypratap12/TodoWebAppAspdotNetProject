namespace TodoWebAppAsp.Net.Model
{
    public class HomeTodoProperty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserEmail { set; get; }

        public DateTime LastModified { get; set; }

    }
}
