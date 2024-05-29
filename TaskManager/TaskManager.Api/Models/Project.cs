namespace TaskManager.Api.Models
{
    public class Project : CommonObject
    {
        public int Id { get; set; }

        public List<User> AllUsers { get; set; } = new List<User>();
        public List<Desk> AllDesks { get; set; }
    }
}
