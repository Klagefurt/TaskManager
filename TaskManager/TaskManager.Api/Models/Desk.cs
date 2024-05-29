namespace TaskManager.Api.Models
{
    public class Desk : CommonObject
    {
        public int Id {  get; set; }
        public bool isPrivate { get; set; }
        public  string  Columns { get; set ; }
        public User Admin { get; set; }
    }
}
