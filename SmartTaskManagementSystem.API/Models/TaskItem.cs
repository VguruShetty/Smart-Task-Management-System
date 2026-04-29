namespace SmartTaskManagementSystem.API.Models
{
    public class TaskItem
    {
        //class propertiesv
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AssignedTo { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
    }
}
