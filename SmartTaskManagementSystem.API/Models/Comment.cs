namespace SmartTaskManagementSystem.API.Models
{
    public class Comment
    {
        //class properties 
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
