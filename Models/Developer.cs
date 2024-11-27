using IS4439_Project_1.Models;
using System.ComponentModel.DataAnnotations;

namespace IS4439_Project_1.Models
{
    public class Developer
    {
        [Key]
        public int DeveloperId { get; set; }

        [Required]
        public string DeveloperName { get; set; }

        public List<Game> Games { get; set; }

    }
}
