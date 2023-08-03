using System.ComponentModel.DataAnnotations;

namespace LearnMVC.Models
{
    public class Users
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
