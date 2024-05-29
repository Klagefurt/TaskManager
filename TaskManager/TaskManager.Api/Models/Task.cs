namespace TaskManager.Api.Models
{
    public class Task : CommonObject
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte[] File {  get; set; }

    }
}
