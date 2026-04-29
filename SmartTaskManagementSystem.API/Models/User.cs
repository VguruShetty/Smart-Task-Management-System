namespace SmartTaskManagementSystem.API.Models
{
    public class User
    {
        //class properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
    }
}
