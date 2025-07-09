using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class ServerData
    {
        public ServerData()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0? false : true;
        }
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
    }
}